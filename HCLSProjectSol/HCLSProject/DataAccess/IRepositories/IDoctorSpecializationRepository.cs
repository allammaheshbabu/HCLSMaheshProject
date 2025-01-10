using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IDoctorSpecializationRepository
    {
        public Task<List<DoctorSpecialization>> GetAll();
        public Task<int> insertDoctorSpecialization(DoctorSpecialization DocSpec);

        public Task<int> updateDoctorSpecialization(DoctorSpecialization DocSpec);

        public Task<int> deleteDoctorSpecialization(int DeptId);
    }
}
