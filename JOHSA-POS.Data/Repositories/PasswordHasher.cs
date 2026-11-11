using System;
using System.Security.Cryptography;
using System.Text;

namespace JOHSA_POS.Data.Repositories
{
    public static class PasswordHasher
    {
        public static bool Verify(
            string password,
            string salt,
            string storedHash)
        {
            if (password == null ||
                salt == null ||
                storedHash == null)
            {
                return false;
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                string combined = salt + password;

                byte[] bytes = Encoding.ASCII.GetBytes(combined);

                byte[] hashBytes = sha256.ComputeHash(bytes);

                string computedHash =
                    BitConverter.ToString(hashBytes)
                    .Replace("-", "");

                return string.Equals(
                    computedHash,
                    storedHash,
                    StringComparison.OrdinalIgnoreCase);
            }
        }

        public static string CreateHash(
             string password,
             out string salt)
        {
            salt = Guid.NewGuid().ToString("N");

            using (SHA256 sha256 = SHA256.Create())
            {
                string combined = salt + password;

                byte[] bytes = Encoding.ASCII.GetBytes(combined);

                byte[] hashBytes = sha256.ComputeHash(bytes);

                string hash =
                    BitConverter.ToString(hashBytes)
                    .Replace("-", "");

                return hash;
            }
        }
    }
}
