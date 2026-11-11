
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JOHSA_POS.Data
{
    public static class Db
    {
        private static string ConnectionString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["EnterprisePOS"]
                    .ConnectionString;
            }
        }

        public static SqlConnection Open()
        {
            SqlConnection connection =
                new SqlConnection(ConnectionString);

            connection.Open();

            return connection;
        }

        public static int Execute(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection connection = Open())
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }
    }
}
