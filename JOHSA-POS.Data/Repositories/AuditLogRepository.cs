using System.Data;
using System.Data.SqlClient;

namespace JOHSA_POS.Data.Repositories
{
    public class AuditLogRepository
    {
        public void CreateLog(int userId, string action, string details)
        {
            using (SqlConnection connection = Db.Open())
            {
                using (SqlCommand command = new SqlCommand("usp_AuditLog_Create", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    command.Parameters.Add("@Action", SqlDbType.NVarChar, 100).Value = action;
                    command.Parameters.Add("@Details", SqlDbType.NVarChar, 500).Value = details;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}