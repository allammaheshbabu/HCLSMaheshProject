using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DBContext
{
    public class HCLSDBContext  :DbContext
    {
        public HCLSDBContext(DbContextOptions<HCLSDBContext> options) : base(options) { }

        public DbSet<AdminTypes> Admintypes { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DoctorDetails> DoctorDetails { get; set; }

        public DbSet<DoctorSpecialization> DoctorSpecialization { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<HelperDetails> HelpersDetails { get; set; }

        public DbSet<LabDetails> LabDetails { get; set; }

        public DbSet<ReceptionistDetails> ReceptionistDetails { get; set; }

        
    }
}
