using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class EmployeeRepository :IEmployeeRepository
    {
        public HCLSDBContext EmpDbContext;
         public EmployeeRepository(HCLSDBContext empDbContext) => EmpDbContext = empDbContext;

        public async Task<int> deleteEmployee(int EmpId)
        {
            var empRepo= await EmpDbContext.Employees.FindAsync(EmpId);
            EmpDbContext.Employees.Remove(empRepo);
            return await EmpDbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await EmpDbContext.Employees.ToListAsync();
        }

        public async Task<int> insertEmployee(Employee Emp)
        {
            await EmpDbContext.Employees.AddAsync(Emp);
            return await EmpDbContext.SaveChangesAsync();
        }

        public async Task<int> updateEmployee(Employee Emp)
        {
            EmpDbContext.Employees.AddAsync(Emp);
            return await EmpDbContext.SaveChangesAsync();
        }
    }
}
