
using System.Collections.Generic;
using System.Data.SqlClient;
using JOHSA_POS.Domain;

namespace JOHSA_POS.Data.Repositories
{
    public sealed class ProductRepository
    {
        public List<JOHSA_POS.Domain.Product> GetAll()
        {
            List<JOHSA_POS.Domain.Product> products =
                new List<JOHSA_POS.Domain.Product>();

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT ProductId, Sku, Barcode, Name, CategoryId,
                         Cost, Price, StockQty, ReorderLevel, IsActive
                  FROM dbo.Products
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
                    product.Barcode = reader["Barcode"] == System.DBNull.Value
                        ? ""
                        : reader["Barcode"].ToString();
                    product.Name = reader["Name"].ToString();
                    product.CategoryId = (int)reader["CategoryId"];
                    product.CostPrice = (decimal)reader["Cost"];
                    product.SellingPrice = (decimal)reader["Price"];
                    product.StockQuantity = (int)reader["StockQty"];
                    product.ReorderLevel = (int)reader["ReorderLevel"];
                    product.IsActive = (bool)reader["IsActive"];

                    products.Add(product);
                }
            }

            return products;
        }


        public int Create(JOHSA_POS.Domain.Product product)
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"INSERT INTO dbo.Products
                   (Sku, Barcode, Name, CategoryId, Price, Cost,
                    StockQty, ReorderLevel, IsActive)
                   VALUES
                   (@Sku, @Barcode, @Name, @CategoryId, @Price, @Cost,
                    @StockQty, @ReorderLevel, @IsActive);
                   SELECT CAST(SCOPE_IDENTITY() AS INT);",
                connection))
            {
                command.Parameters.AddWithValue("@Sku", product.Sku);

                command.Parameters.AddWithValue(
                    "@Barcode",
                    string.IsNullOrWhiteSpace(product.Barcode)
                        ? (object)System.DBNull.Value
                        : product.Barcode);

                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                command.Parameters.AddWithValue("@Price", product.SellingPrice);
                command.Parameters.AddWithValue("@Cost", product.CostPrice);
                command.Parameters.AddWithValue("@StockQty", product.StockQuantity);
                command.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                command.Parameters.AddWithValue("@IsActive", product.IsActive);

                return (int)command.ExecuteScalar();
            }
        }


        public void Update(JOHSA_POS.Domain.Product product)
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"UPDATE dbo.Products
                    SET Sku = @Sku,
                        Barcode = @Barcode,
                        Name = @Name,
                        CategoryId = @CategoryId,
                        Price = @Price,
                        Cost = @Cost,
                        StockQty = @StockQty,
                        ReorderLevel = @ReorderLevel,
                        IsActive = @IsActive,
                        UpdatedAt = GETDATE()
                WHERE ProductId = @ProductId",
                connection))
            {
                command.Parameters.AddWithValue("@ProductId", product.Id);
                command.Parameters.AddWithValue("@Sku", product.Sku);

                command.Parameters.AddWithValue(
                    "@Barcode",
                    string.IsNullOrWhiteSpace(product.Barcode)
                        ? (object)System.DBNull.Value
                        : product.Barcode);

                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                command.Parameters.AddWithValue("@Price", product.SellingPrice);
                command.Parameters.AddWithValue("@Cost", product.CostPrice);
                command.Parameters.AddWithValue("@StockQty", product.StockQuantity);
                command.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                command.Parameters.AddWithValue("@IsActive", product.IsActive);

                command.ExecuteNonQuery();
            }
        }


        public void Delete(int productId)
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"UPDATE dbo.Products
                    SET IsActive = 0,
                        UpdatedAt = GETDATE()
                    WHERE ProductId = @ProductId",
                connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);

                command.ExecuteNonQuery();
            }
        }

    }
}
