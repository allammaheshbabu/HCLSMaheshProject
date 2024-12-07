using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IAdminTypesRepository
    {
        public Task<List<AdminTypes>> getAllAdminTypes();

        public Task<AdminTypes> getAdminTypeById(int AdminTypeId);

        public Task<int> insertAdminTypes(AdminTypes admin);

        public Task<int> updateAdminTypes(AdminTypes admin);

        public Task<int> deleteAdminTypes(int AdminTypeId);
    }
}
