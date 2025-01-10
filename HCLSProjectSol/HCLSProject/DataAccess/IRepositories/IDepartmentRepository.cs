using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IDepartmentRepository

    {
        public Task<List<Department>> GetAll();
        public Task<int> insertDepartment(Department Dept);

        public Task<int> updateDepartment(Department Dept);

        public Task<int> deleteDepartment(int DeptId);
    }
}
