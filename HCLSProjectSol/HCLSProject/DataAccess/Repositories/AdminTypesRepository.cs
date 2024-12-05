using HCLSProject.DataAccess.IRepositories;

namespace HCLSProject.DataAccess.Repositories
{
    public class AdminTypesRepository : IAdminTypesRepository
    {
        public AdminTypesRepository adminTypesRepository;

        public AdminTypesRepository(AdminTypesRepository _adminTypesRepository)
        {
            adminTypesRepository = _adminTypesRepository;
        }
    }
}
