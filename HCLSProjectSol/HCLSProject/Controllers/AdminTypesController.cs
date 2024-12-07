using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminTypesController : ControllerBase
    {
        public IAdminTypesRepository AdminTypesRepo;

        public AdminTypesController(IAdminTypesRepository adminTypesRepo)
        {
            this.AdminTypesRepo = adminTypesRepo;

        }

        [HttpGet]
        [Route("GetAllAdminTypes")]
        public async Task<IActionResult> GetAllAdminTypes()
        {
            try
            {
                var admintypes = await AdminTypesRepo.getAllAdminTypes();

                if (admintypes.Count > 0)
                {
                    return Ok(admintypes);
                }
                else
                {
                    return BadRequest("NO records found....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAdminTypeById")]
        public async Task<IActionResult> GetAdminTypeById(int AdmintypeId)
        {
            try
            {
                var admintyp_id = await AdminTypesRepo.getAdminTypeById(AdmintypeId);
                if (admintyp_id != null)
                {
                    return Ok(admintyp_id);
                }
                else
                {
                    return NotFound("No data found...");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }

        [HttpPost]
        [Route("InsertAdmintypes")]
        public async Task<IActionResult> InsertAdmintypes([FromBody] AdminTypes admintypes)
        {
            try
            {
                var insertadmin = await AdminTypesRepo.insertAdminTypes(admintypes);
                if (insertadmin > 0)
                {
                    return Ok(insertadmin);
                }
                else
                {
                    return BadRequest("No Data inserted");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }
         
        [HttpPut]
        [Route("UpdateAdmintypes")]
        public async Task<IActionResult> UpdateAdmintypes([FromBody]AdminTypes admintypes)
        {
            try
            {
                var insertadmin = await AdminTypesRepo.updateAdminTypes(admintypes);
                if (insertadmin > 0)
                {
                    return Ok(insertadmin);
                }
                else
                {
                    return BadRequest("No Data inserted");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteAdminTypes")]
        public async Task<IActionResult> DeleteAdminTypes(int admintypesId)
        {
            try
            {
                var deleteadmintype = await AdminTypesRepo.deleteAdminTypes(admintypesId);
                if (deleteadmintype > 0)
                {
                    return Ok(deleteadmintype);
                }
                else
                {
                    return BadRequest("data not deleted.....");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sorry  for inconvineance...\n we will solve this issue soon......\n " + ex.Message);
            }
        }
    }
}

