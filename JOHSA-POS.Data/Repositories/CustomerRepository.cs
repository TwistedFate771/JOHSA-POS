
using System.Collections.Generic;
using System.Data.SqlClient;
using JOHSA_POS.Domain;

namespace JOHSA_POS.Data.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                "SELECT CustomerId, FullName FROM dbo.Customers ORDER BY FullName",
                connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer customer = new Customer();

                    customer.CustomerId = (int)reader["CustomerId"];
                    customer.FullName = reader["FullName"].ToString();

                    customers.Add(customer);
                }
            }

            return customers;
        }
    }
}
