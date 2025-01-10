using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class HelperDetailsRepository : IHelperDetailsRepository
    {
        public HCLSDBContext HelperContext;
        public HelperDetailsRepository(HCLSDBContext _HelperContext)=> HelperContext = _HelperContext;

        public async Task<int> deleteHelperDetails(int HelperId)
        {
           var HelperDet = await HelperContext.HelpersDetails.FindAsync(HelperId);
            HelperContext.HelpersDetails.Remove(HelperDet);
            return await HelperContext.SaveChangesAsync();
        }

        public async Task<List<HelperDetails>> GetAll()
        {
            return await HelperContext.HelpersDetails.ToListAsync();
        }

        public async Task<int> insertHelperDetails(HelperDetails Helperdetails)
        {
           await HelperContext.HelpersDetails.AddAsync(Helperdetails);
            return await  HelperContext.SaveChangesAsync();
        }

        public async Task<int> updateHelperDetails(HelperDetails Helperdetails)
        {
            HelperContext.HelpersDetails.Update(Helperdetails);
            return await HelperContext.SaveChangesAsync();
        }
    }
}
