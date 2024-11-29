using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DBContext
{
    public class HCLSDBContext  :DbContext
    {
        public HCLSDBContext(DbContextOptions<HCLSDBContext> options) : base(options) { }

        public DbSet<AdminTypes> admintype { get; set; }

        public DbSet<Admin> admin { get; set; }
    }
}
