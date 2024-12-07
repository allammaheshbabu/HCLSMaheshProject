using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class AdminTypesRepository : IAdminTypesRepository
    {
        public HCLSDBContext adminTypescontext;

        public AdminTypesRepository(HCLSDBContext _adminTypescontex)
        {
            adminTypescontext = _adminTypescontex;
        }

        public async Task<int> deleteAdminTypes(int AdminTypeId)
        {
            var admintype= await adminTypescontext.Admintypes.FindAsync(AdminTypeId);
            adminTypescontext.Admintypes.Remove(admintype);
            return await adminTypescontext.SaveChangesAsync();

        }

        public async Task<AdminTypes> getAdminTypeById(int AdminTypeId)
        {
           return await adminTypescontext.Admintypes.FindAsync(AdminTypeId);
           
        }

        public async Task<List<AdminTypes>> getAllAdminTypes()
        {
           return await adminTypescontext.Admintypes.ToListAsync();
        }

        public async Task<int> insertAdminTypes(AdminTypes admin)
        {
             await adminTypescontext.Admintypes.AddAsync(admin);
            return await adminTypescontext.SaveChangesAsync();
        }

        public async Task<int> updateAdminTypes(AdminTypes admin)
        {
             adminTypescontext.Admintypes.Update(admin);
            return await adminTypescontext.SaveChangesAsync();
        }
    }
}
