using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JOHSA_POS.Data.Repositories
{
    public sealed class InventoryRepository
    {
        public List<JOHSA_POS.Domain.Product> GetInventory()
        {
            List<JOHSA_POS.Domain.Product> products =
                new List<JOHSA_POS.Domain.Product>();

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT ProductId, Sku, Name, StockQty,
                         ReorderLevel, IsActive
                  FROM dbo.Products
                  WHERE IsActive = 1
                  ORDER BY Name",
                connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JOHSA_POS.Domain.Product product =
                        new JOHSA_POS.Domain.Product();

                    product.Id = (int)reader["ProductId"];
                    product.Sku = reader["Sku"].ToString();
                    product.Name = reader["Name"].ToString();
                    product.StockQuantity = (int)reader["StockQty"];
                    product.ReorderLevel = (int)reader["ReorderLevel"];
                    product.IsActive = (bool)reader["IsActive"];

                    products.Add(product);
                }
            }

            return products;
        }

        public void ChangeStock(
            int productId,
            int changeQty,
            string reason,
            int userId)
        {
            using (SqlConnection connection = Db.Open())
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(
                        @"UPDATE dbo.Products
                          SET StockQty = StockQty + @ChangeQty,
                              UpdatedAt = GETDATE()
                          WHERE ProductId = @ProductId
                            AND IsActive = 1
                            AND StockQty + @ChangeQty >= 0",
                        connection,
                        transaction))
                    {
                        command.Parameters.AddWithValue(
                            "@ProductId", productId);

                        command.Parameters.AddWithValue(
                            "@ChangeQty", changeQty);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new InvalidOperationException(
                                "The stock could not be changed. Check the product and available quantity.");
                        }
                    }

                    using (SqlCommand command = new SqlCommand(
                        @"INSERT INTO dbo.InventoryLog
                          (ProductId, ChangeQty, Reason, UserId, CreatedAt)
                          VALUES
                          (@ProductId, @ChangeQty, @Reason, @UserId, GETDATE())",
                        connection,
                        transaction))
                    {
                        command.Parameters.AddWithValue(
                            "@ProductId", productId);

                        command.Parameters.AddWithValue(
                            "@ChangeQty", changeQty);

                        command.Parameters.AddWithValue(
                            "@Reason", reason);

                        command.Parameters.AddWithValue(
                            "@UserId", userId);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}