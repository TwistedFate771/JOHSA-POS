using System;
using System.Data;
using System.Data.SqlClient;
using DomainUser = JOHSA_POS.Domain.User;
using DomainUserRole = JOHSA_POS.Domain.UserRole;

namespace JOHSA_POS.Data.Repositories
{
    public sealed class UserRepository
    {
        public DomainUser Login(string username, string password)
        {
            DomainUser loggedInUser = null;

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command =
                new SqlCommand("dbo.usp_Login", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    "@Username",
                    SqlDbType.NVarChar,
                    50).Value = username;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    bool isActive = Convert.ToBoolean(
                        reader["IsActive"]);

                    if (!isActive)
                    {
                        return null;
                    }

                    string storedHash =
                        Convert.ToString(reader["PasswordHash"]);

                    string salt =
                        Convert.ToString(reader["Salt"]);

                    bool passwordIsCorrect =
                        PasswordHasher.Verify(
                            password,
                            salt,
                            storedHash);

                    if (!passwordIsCorrect)
                    {
                        return null;
                    }

                    loggedInUser = new DomainUser
                    {
                        Id = Convert.ToInt32(reader["UserId"]),
                        Username = Convert.ToString(reader["Username"]),
                        PasswordHash = storedHash,
                        DisplayName = Convert.ToString(reader["FullName"]),
                        Role = (DomainUserRole)Convert.ToInt32(reader["RoleId"]),
                        IsActive = isActive
                    };
                }

                using (SqlCommand updateCommand =
                    new SqlCommand(
                        "UPDATE dbo.Users SET LastLoginAt = GETDATE() WHERE UserId = @UserId",
                        connection))
                {
                    updateCommand.Parameters.Add(
                        "@UserId",
                        SqlDbType.Int).Value = loggedInUser.Id;

                    updateCommand.ExecuteNonQuery();
                }
            }

            return loggedInUser;
        }

        public DataTable GetAllUsers()
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"SELECT
                    u.UserId,
                    u.Username,
                    u.FullName,
                    r.RoleName,
                    u.IsActive,
                    u.CreatedAt,
                    u.LastLoginAt
                 FROM dbo.Users u
                 INNER JOIN dbo.Roles r
                    ON u.RoleId = r.RoleId
                 ORDER BY u.UserId", connection))
            {
                DataTable table = new DataTable();

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }

                return table;
            }
        }

        public void AddUser(
            string username,
            string password,
            string fullName,
            int roleId)
        {
            string salt;

            string passwordHash = PasswordHasher.CreateHash(password, out salt);

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"INSERT INTO dbo.Users
                    (Username, PasswordHash, Salt, FullName,
                     RoleId, IsActive, CreatedAt)
                 VALUES
                    (@Username, @PasswordHash, @Salt, @FullName,
                     @RoleId, 1, GETDATE())", connection))
            {
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;

                command.Parameters.Add("@PasswordHash", SqlDbType.VarChar, 64).Value = passwordHash;

                command.Parameters.Add("@Salt", SqlDbType.VarChar, 32).Value = salt;

                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = fullName;

                command.Parameters.Add("@RoleId", SqlDbType.Int).Value = roleId;

                command.ExecuteNonQuery();
            }
        }

        public void UpdateUser(
            int userId,
            string fullName,
            int roleId,
            bool isActive)
        {
            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"UPDATE dbo.Users
                  SET FullName = @FullName,
                      RoleId = @RoleId,
                      IsActive = @IsActive
                  WHERE UserId = @UserId", connection))
            {
                command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = fullName;

                command.Parameters.Add("@RoleId", SqlDbType.Int).Value = roleId;

                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                command.ExecuteNonQuery();
            }
        }

        public void ResetPassword(int userId, string newPassword)
        {
            string salt;

            string passwordHash = PasswordHasher.CreateHash(newPassword, out salt);

            using (SqlConnection connection = Db.Open())
            using (SqlCommand command = new SqlCommand(
                @"UPDATE dbo.Users
                  SET PasswordHash = @PasswordHash,
                      Salt = @Salt
                  WHERE UserId = @UserId", connection))
            {
                command.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                command.Parameters.Add("@PasswordHash", SqlDbType.VarChar, 64).Value = passwordHash;

                command.Parameters.Add("@Salt", SqlDbType.VarChar, 32).Value = salt;

                command.ExecuteNonQuery();
            }
        }
    }
}
