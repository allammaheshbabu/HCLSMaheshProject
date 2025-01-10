using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IReceptionistDetailsRepository
    {
        public Task<List<ReceptionistDetails>> GetAll();
        public Task<int> insertReceptionistDetails(ReceptionistDetails Recpdetails);

        public Task<int> updateReceptionistDetails(ReceptionistDetails Recpdetails);

        public Task<int> deleteReceptionistDetails(int RecpId);
    }
}
