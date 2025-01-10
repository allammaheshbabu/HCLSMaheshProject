using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class LabDetailsRepository :ILabDetailsRepository
    {
        public HCLSDBContext LabDbContext;
        public LabDetailsRepository(HCLSDBContext _LabDbContext) => LabDbContext = _LabDbContext;

        public async Task<int> deleteLabDetails(int LabId)
        {
            var Lab= await LabDbContext.LabDetails.FindAsync(LabId);    
            LabDbContext.LabDetails.Remove(Lab);
            return await LabDbContext.SaveChangesAsync();
        }

        public async Task<List<LabDetails>> GetAll()
        {
            return await  LabDbContext.LabDetails.ToListAsync();
        }

        public async Task<int> insertLabDetails(LabDetails Labdetails)
        {
            await LabDbContext.LabDetails.AddAsync(Labdetails);
            return await LabDbContext.SaveChangesAsync();
        }

        public async Task<int> updateLabDetails(LabDetails Labdetails)
        {
            LabDbContext.LabDetails.AddAsync(Labdetails);
            return await LabDbContext.SaveChangesAsync();
        }
    }
}
