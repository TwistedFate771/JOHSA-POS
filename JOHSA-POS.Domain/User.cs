
namespace JOHSA_POS.Domain
{
    public enum UserRole
    {
        Admin = 1,
        Manager = 2,
        Cashier = 3
    }

    public sealed class User
    {
        public int Id { 
            get; 
            set; 
        }

        public string Username {
            get;
            set; 
        }

        public string PasswordHash {
            get;
            set; 
        }

        public string DisplayName {
            get; 
            set; 
        }

        public UserRole Role { 
            get; 
            set;
        }

        public bool IsActive {
            get; 
            set;
        }
    }
}
