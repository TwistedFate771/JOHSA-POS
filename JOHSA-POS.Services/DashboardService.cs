using JOHSA_POS.Data;
using System;
using System.Data.SqlClient;

namespace JOHSA_POS.Services.Services
{
    public class DashboardService
    {
        public decimal GetTodaysSales()
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT ISNULL(SUM(Total), 0)
                  FROM dbo.Orders
                  WHERE OrderDate >= @Today
                    AND OrderDate < @Tomorrow
                    AND (Status IS NULL OR Status <> 'Cancelled')",
                connection))
            {
                command.Parameters.AddWithValue(
                    "@Today", DateTime.Today);

                command.Parameters.AddWithValue(
                    "@Tomorrow", DateTime.Today.AddDays(1));

                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }

        public int GetOrdersToday()
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT COUNT(*)
                  FROM dbo.Orders
                  WHERE OrderDate >= @Today
                    AND OrderDate < @Tomorrow
                    AND (Status IS NULL OR Status <> 'Cancelled')",
                connection))
            {
                command.Parameters.AddWithValue(
                    "@Today", DateTime.Today);

                command.Parameters.AddWithValue(
                    "@Tomorrow", DateTime.Today.AddDays(1));

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetLowStockProducts()
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT COUNT(*)
                  FROM dbo.Products
                  WHERE IsActive = 1
                    AND StockQty <= ReorderLevel",
                connection))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetActiveProducts()
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT COUNT(*)
                  FROM dbo.Products
                  WHERE IsActive = 1",
                connection))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}
