using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DataAccess.Repositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public  IAdminRepository AdminRepo { get; set; }

        public AdminController(IAdminRepository AdminRepo) 
        {
           this.AdminRepo = AdminRepo;
        }
        [HttpGet]
        [Route("GetAllAdmins")]
        public async Task<IActionResult> GetAllAdmins()
        {
            try
            {
                var alladmins = await AdminRepo.getAllAdmins();
                if (alladmins.Count > 0)
                {
                    return Ok(alladmins);
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


        [HttpGet]
        [Route("GetAdminById")]

        public async Task<IActionResult> GetAdminById(int AdminId)
        {
            try
            {
                var admin_by_id = await AdminRepo.getAdminById(AdminId);

                if (admin_by_id != null)
                {
                    return Ok(admin_by_id);
                }
                else
                {
                    return BadRequest("Data not found...");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }


        }

        [HttpPost]
        [Route("InsertAdmin")]
        public async Task<IActionResult> InsertAdmin([FromBody]Admin admin)
        {
            try
            {
               var count= await AdminRepo.insertAdmin(admin);
                if (count > 0)
                {
                    return Ok(count+" Records inserted successfully...");
                }
                else
                {
                    return BadRequest("Data not Inserted...");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n "+ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin([FromBody] Admin admin)
        {
            try
            {
                var count = await AdminRepo.updateAdmin(admin);
                if (count > 0)
                {
                    return Ok(count + " Records inserted successfully...");
                }
                else
                {
                    return BadRequest("Data not Inserted...");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }

       

        [HttpDelete]
        [Route("deleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int AdminId)
        {
            try
            {
                var deleteadmin = await AdminRepo.deleteAdmin(AdminId);

                if (deleteadmin > 0)
                {
                    return Ok(deleteadmin);
                }
                else
                {
                    return NotFound("No records deleted....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }

        }


    }
}
