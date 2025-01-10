using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class DoctorSpecializationRepository :IDoctorSpecializationRepository
    {
        HCLSDBContext DocSpclDbContext;
        public DoctorSpecializationRepository(HCLSDBContext _DocSpclDbContext) => DocSpclDbContext = _DocSpclDbContext;

        public async Task<int> deleteDoctorSpecialization(int DeptId)
        {
            var docspcl= await DocSpclDbContext.DoctorSpecialization.FindAsync(DeptId);   
            DocSpclDbContext.DoctorSpecialization.Remove(docspcl);
            return await DocSpclDbContext.SaveChangesAsync();
        }

        public async Task<List<DoctorSpecialization>> GetAll()
        {
           return await DocSpclDbContext.DoctorSpecialization.ToListAsync();
        }

        public async Task<int> insertDoctorSpecialization(DoctorSpecialization DocSpec)
        {
            await DocSpclDbContext.DoctorSpecialization.AddAsync(DocSpec);
            return await DocSpclDbContext.SaveChangesAsync();
        }

        public async Task<int> updateDoctorSpecialization(DoctorSpecialization DocSpec)
        {
             DocSpclDbContext.DoctorSpecialization.Update(DocSpec);
            return await DocSpclDbContext.SaveChangesAsync();
        }
    }
}
