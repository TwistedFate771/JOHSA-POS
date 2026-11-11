
using JOHSA_POS.Domain;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public sealed class LoginService
    {
        private readonly UserRepository userRepository;

        public LoginService()
        {
            userRepository = new UserRepository();
        }

        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return userRepository.Login(username, password);
        }
    }
}
