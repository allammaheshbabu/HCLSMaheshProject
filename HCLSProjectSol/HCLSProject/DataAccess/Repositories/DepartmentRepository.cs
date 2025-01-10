using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public HCLSDBContext DeptContext;
        public DepartmentRepository(HCLSDBContext _DeptContext) => DeptContext=_DeptContext;


        public async Task<int> deleteDepartment(int DeptId)
        {
          var DeptRepo=await DeptContext.Departments.FindAsync(DeptId);
            DeptContext.Departments.Remove(DeptRepo);
            return await DeptContext.SaveChangesAsync();
        }

        public  async Task<List<Department>> GetAll()
        {
            return await DeptContext.Departments.ToListAsync();
        }

        public  async Task<int> insertDepartment(Department Dept)
        {
           await DeptContext.Departments.AddAsync(Dept);
            return await DeptContext.SaveChangesAsync();
        }

        public async Task<int> updateDepartment(Department Dept)
        {
            DeptContext.Departments.Update(Dept);
            return await DeptContext.SaveChangesAsync();
        }
    }
}
