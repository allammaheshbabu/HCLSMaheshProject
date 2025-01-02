using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public HCLSDBContext admincontext;

        public AdminRepository(HCLSDBContext _admincontext)
        {
            admincontext = _admincontext;
        }

        public async Task<Admin> getAdminById(int AdminId)
        {
             return await admincontext.Admins!.FindAsync(AdminId);
        }

        public async Task<List<Admin>> getAllAdmins()
        {
          return await admincontext.Admins.ToListAsync();
        }

        public async Task<int> insertAdmin(Admin admin)
        {
           await admincontext.Admins.AddAsync(admin);
            return await admincontext.SaveChangesAsync();
        }

        public async Task<int> updateAdmin(Admin admin)
        {
             admincontext.Admins.Update(admin);
            return await admincontext.SaveChangesAsync();
        }

        public async Task<int> deleteAdmin(int AdminId)
        {
             var admin = await admincontext.Admins.FindAsync(AdminId);
            admincontext.Admins.Remove(admin);
            return await admincontext.SaveChangesAsync();

        }

        public async Task<Admin> checkAdminLogin(string Email, string Password)
        {
            return await admincontext.Admins!.Where(x => x.Email == Email && x.Password==Password).SingleOrDefaultAsync();
        }

        public async Task<int> ActivateAdmin(string Email)
        {
            var Admin=await admincontext.Admins!.Where(x => x.Email == Email).SingleOrDefaultAsync();
            Admin.ActiveStatus = true;
            return await updateAdmin(Admin);
        }
    }
}
