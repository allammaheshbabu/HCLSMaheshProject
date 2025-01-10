using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeRepository EmployeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var EmpList = await EmployeeRepository.GetAll();
                if (EmpList.Count > 0)
                {
                    return Ok(EmpList);
                }
                else
                {
                    return NotFound("No Records.....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }
        [HttpPost]
        [Route("InsertEmployee")]
        public async Task<IActionResult> InsertEmployee([FromBody] Employee Emp)
        {
            try
            {
                var EmpRepo = await EmployeeRepository.insertEmployee(Emp);
                if (EmpRepo > 0)
                {
                    return Ok(EmpRepo);
                }
                else
                {
                    return NotFound("No Records.....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employee Emp)
        {
            try
            {
                var EmpRepo = await EmployeeRepository.updateEmployee(Emp);
                if (EmpRepo > 0)
                {
                    return Ok(EmpRepo);
                }
                else
                {
                    return NotFound("No Records.....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int EmpId)
        {
            try
            {
                var EmpRepo = await EmployeeRepository.deleteEmployee(EmpId);
                if (EmpRepo > 0)
                {
                    return Ok(EmpRepo);
                }
                else
                {
                    return NotFound("No Records.....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }
    }                   
}
