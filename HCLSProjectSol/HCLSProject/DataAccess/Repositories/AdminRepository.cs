using HCLSProject.DataAccess.IRepositories;

namespace HCLSProject.DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public AdminRepository adminRepository;

        public AdminRepository(AdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }
    }
}
