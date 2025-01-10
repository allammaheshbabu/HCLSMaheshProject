using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface ILabDetailsRepository
    {
        public Task<List<LabDetails>> GetAll();
        public Task<int> insertLabDetails(LabDetails Labdetails);

        public Task<int> updateLabDetails(LabDetails Labdetails);

        public Task<int> deleteLabDetails(int LabId);
    }
}
