using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class ReceptionistDetailsRepository :IReceptionistDetailsRepository
    {
        public HCLSDBContext ReceptionistDbContext;

        public ReceptionistDetailsRepository(HCLSDBContext receptionistDbContext)
        {
            ReceptionistDbContext = receptionistDbContext;
        }

        public async Task<int> deleteReceptionistDetails(int RecpId)
        {
            var RecpDet= await ReceptionistDbContext.ReceptionistDetails.FindAsync(RecpId);
            ReceptionistDbContext.ReceptionistDetails.Remove(RecpDet);
            return await ReceptionistDbContext.SaveChangesAsync();
        }

        public async Task<List<ReceptionistDetails>> GetAll()
        {
           return await ReceptionistDbContext.ReceptionistDetails.ToListAsync();
        }

        public async Task<int> insertReceptionistDetails(ReceptionistDetails Recpdetails)
        {
            await ReceptionistDbContext.ReceptionistDetails.AddAsync(Recpdetails);
            return await ReceptionistDbContext.SaveChangesAsync();
        }

        public  async Task<int> updateReceptionistDetails(ReceptionistDetails Recpdetails)
        {
             ReceptionistDbContext.ReceptionistDetails.AddAsync(Recpdetails);
            return await ReceptionistDbContext.SaveChangesAsync();
        }
    }
}
