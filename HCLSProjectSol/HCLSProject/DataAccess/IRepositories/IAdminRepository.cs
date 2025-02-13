﻿using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IAdminRepository
    {
        public Task<List<Admin>> getAllAdmins(); 
        
        public Task<Admin> getAdminById(int AdminId);
        public Task<Admin> checkAdminLogin(string Email, string Psssword);


        public Task<int> insertAdmin(Admin admin);

        public Task<int> updateAdmin(Admin admin);

        public Task<int> deleteAdmin(int AdminId);

        public Task<int> ActivateAdmin(string Email);

        public Task<string> BringPassword(string Email);

        public Task<int> ChangePassword(string Email,string Password);


    }
}
