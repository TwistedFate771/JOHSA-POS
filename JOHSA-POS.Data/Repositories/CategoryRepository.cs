using System.Collections.Generic;
using System.Data.SqlClient;

namespace JOHSA_POS.Data.Repositories
{
    public class CategoryRepository
    {
        public List<KeyValuePair<int, string>> GetAll()
        {
            List<KeyValuePair<int, string>> categories =
                new List<KeyValuePair<int, string>>();

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                "SELECT CategoryId, Name FROM dbo.Categories ORDER BY Name",
                connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    categories.Add(
                        new KeyValuePair<int, string>(
                            (int)reader["CategoryId"],
                            reader["Name"].ToString()));
                }
            }

            return categories;
        }
    }
}
