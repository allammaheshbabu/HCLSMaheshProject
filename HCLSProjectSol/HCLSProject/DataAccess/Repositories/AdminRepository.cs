﻿using HCLSProject.DataAccess.IRepositories;
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

        public async Task<Admin> GetAdminById(int AdminId)
        {
             return await admincontext.Admins!.FindAsync(AdminId);
        }

        public async Task<List<Admin>> GetAllAdmins()
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
    }
}
