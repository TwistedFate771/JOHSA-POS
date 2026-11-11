using System.Data;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public class UserManagementService
    {
        private UserRepository userRepository;
        private AuditLogRepository auditLogRepository;

        public UserManagementService()
        {
            userRepository = new UserRepository();
            auditLogRepository = new AuditLogRepository();
        }

        public DataTable GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        public void AddUser(
            string username,
            string password,
            string fullName,
            int roleId)
        {
            userRepository.AddUser(
                username,
                password,
                fullName,
                roleId);
        }

        public void UpdateUser(
            int userId,
            string fullName,
            int roleId,
            bool isActive)
        {
            userRepository.UpdateUser(
                userId,
                fullName,
                roleId,
                isActive);
        }

        public void ResetPassword(
            int userId,
            string newPassword)
        {
            userRepository.ResetPassword(
                userId,
                newPassword);
        }

        public void CreateAuditLog(int userId, string action, string details)
        {
            auditLogRepository.CreateLog(userId, action, details);
        }
    }
}