
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Collections.Generic;
using JOHSA_POS.Domain;

namespace JOHSA_POS.Data.Repositories
{
    public class OrderRepository
    {
        public int CreateOrder(
            int userId,
            int? customerId,
            string paymentMethod,
            decimal discountAmount,
            decimal taxRate,
            decimal amountPaid,
            List<CartItem> items)
        {
           
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                "dbo.usp_Order_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserId", userId);

                if (customerId.HasValue)
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@CustomerId", DBNull.Value);
                }

                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                command.Parameters.AddWithValue("@TaxRate", taxRate);
                command.Parameters.AddWithValue("@AmountPaid", amountPaid);

                command.Parameters.Add("@ItemsXml", SqlDbType.Xml).Value =
                    CreateItemsXml(items);

                object result = command.ExecuteScalar();

                return Convert.ToInt32(result);
            }
        }

        private string CreateItemsXml(List<CartItem> items)
        {
            XmlDocument document = new XmlDocument();

            XmlElement root = document.CreateElement("Items");
            document.AppendChild(root);

            foreach (CartItem item in items)
            {
                XmlElement itemElement = document.CreateElement("Item");

                itemElement.SetAttribute(
                    "ProductId", item.ProductId.ToString());

                itemElement.SetAttribute(
                    "Quantity", item.Quantity.ToString());

                root.AppendChild(itemElement);
            }

            return document.OuterXml;
        }
    }
}
