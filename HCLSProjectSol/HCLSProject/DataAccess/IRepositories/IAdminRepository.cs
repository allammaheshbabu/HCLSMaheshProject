using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IAdminRepository
    {
        public Task<List<Admin>> GetAllAdmins(); 
        
        public Task<Admin> GetAdminById(int AdminId);

        public Task<int> insertAdmin(Admin admin);

        public Task<int> updateAdmin(Admin admin);

        public Task<int> deleteAdmin(int AdminId);


    }
}
