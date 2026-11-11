using System;
using System.Data;
using System.Data.SqlClient;

namespace JOHSA_POS.Data.Repositories
{
    public class SalesAnalyticsRepository
    {
        public DataTable GetSalesSummary()
        {
            using (SqlConnection connection = Db.Open())
            {
                using (SqlCommand command = new SqlCommand(
                    @"SELECT
                        COUNT(OrderId) AS TotalOrders,
                        ISNULL(SUM(Total), 0) AS TotalSales,
                        ISNULL(SUM(DiscountAmount), 0) AS TotalDiscounts,
                        ISNULL(SUM(TaxAmount), 0) AS TotalTax
                      FROM Orders
                      WHERE Status = 'Completed'", connection))
                {
                    DataTable table = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                    return table;
                }
            }
        }

        public DataTable GetDailySales()
        {
            using (SqlConnection connection = Db.Open())
            {
                using (SqlCommand command = new SqlCommand(
                    @"SELECT
                        CAST(OrderDate AS DATE) AS SalesDate,
                        COUNT(OrderId) AS TotalOrders,
                        SUM(Total) AS TotalSales
                      FROM Orders
                      WHERE Status = 'Completed'
                      GROUP BY CAST(OrderDate AS DATE)
                      ORDER BY SalesDate DESC", connection))
                {
                    DataTable table = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                    return table;
                }
            }
        }

        public DataTable GetMonthlySales()
        {
            using (SqlConnection connection = Db.Open())
            {
                using (SqlCommand command = new SqlCommand(
                    @"SELECT
                        YEAR(OrderDate) AS SalesYear,
                        MONTH(OrderDate) AS SalesMonth,
                        COUNT(OrderId) AS TotalOrders,
                        SUM(Total) AS TotalSales
                      FROM Orders
                      WHERE Status = 'Completed'
                      GROUP BY YEAR(OrderDate), MONTH(OrderDate)
                      ORDER BY SalesYear DESC, SalesMonth DESC", connection))
                {
                    DataTable table = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                    return table;
                }
            }
        }

        public DataTable GetSalesByPaymentMethod()
        {
            using (SqlConnection connection = Db.Open())
            {
                using (SqlCommand command = new SqlCommand(
                    @"SELECT
                        PaymentMethod,
                        COUNT(OrderId) AS TotalOrders,
                        SUM(Total) AS TotalSales
                      FROM Orders
                      WHERE Status = 'Completed'
                      GROUP BY PaymentMethod
                      ORDER BY PaymentMethod", connection))
                {
                    DataTable table = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                    return table;
                }
            }
        }

        public DataTable GetTopSellingProducts()
        {
            using (SqlConnection connection = Db.Open())
            {
                using (SqlCommand command = new SqlCommand(
                    @"SELECT
                        p.Name AS ProductName,
                        SUM(od.Quantity) AS TotalQuantitySold,
                        SUM(od.LineTotal) AS TotalSales
                      FROM OrderDetails od
                      INNER JOIN Products p
                        ON od.ProductId = p.ProductId
                      INNER JOIN Orders o
                        ON od.OrderId = o.OrderId
                      WHERE o.Status = 'Completed'
                      GROUP BY p.Name
                      ORDER BY TotalQuantitySold DESC", connection))
                {
                    DataTable table = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                    return table;
                }
            }
        }
    }
}