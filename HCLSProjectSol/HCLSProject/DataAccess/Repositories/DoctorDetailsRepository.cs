using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class DoctorDetailsRepository : IDoctorDetailsRepository
    {
        public HCLSDBContext DocDetContext;
        public DoctorDetailsRepository(HCLSDBContext _DocDetContext) => DocDetContext = _DocDetContext;


        public async Task<int> deleteDoctorDetails(int DeptId)
        {
           var Dept=  await DocDetContext.DoctorDetails.FindAsync(DeptId);
            DocDetContext.DoctorDetails.Remove(Dept);
            return await DocDetContext.SaveChangesAsync();

        }

        public async Task<List<DoctorDetails>> GetAll()
        {
            return await DocDetContext.DoctorDetails.ToListAsync();
        }

        public async Task<int> insertDoctorDetails(DoctorDetails Doctordetails)
        {
            await DocDetContext.DoctorDetails.AddAsync(Doctordetails);
            return await DocDetContext.SaveChangesAsync();
        }

        public async Task<int> updateDoctorDetails(DoctorDetails Doctordetails)
        {
             DocDetContext.DoctorDetails.AddAsync(Doctordetails);
            return await DocDetContext.SaveChangesAsync();
        }
    }
}
