using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorDetailsController : ControllerBase
    {
        public IDoctorDetailsRepository DoctorDetailsRepository;

        public DoctorDetailsController(IDoctorDetailsRepository doctorDetailsRepository)
        {
            DoctorDetailsRepository = doctorDetailsRepository;
        }

        [HttpGet]
        [Route("GetAllDoctorDetails")]
        public async Task<IActionResult> GetAllDoctorDetails()
        {
            try
            {
                var DocList = await DoctorDetailsRepository.GetAll();
                if (DocList.Count > 0)
                {
                    return Ok(DocList);
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
        [Route("InsertDoctorDetails")]
        public async Task<IActionResult> InsertDoctorDetails([FromBody]  DoctorDetails DocDetl)
        {
            try
            {
                var DoctRepo = await DoctorDetailsRepository.insertDoctorDetails(DocDetl);
                if (DoctRepo > 0)
                {
                    return Ok(DoctRepo);
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
        [Route("UpdateDoctorDetails")]
        public async Task<IActionResult> UpdateDoctorDetails([FromBody] DoctorDetails DocDetl)
        {
            try
            {
                var DoctRepo = await DoctorDetailsRepository.updateDoctorDetails(DocDetl);
                if (DoctRepo > 0)
                {
                    return Ok(DoctRepo);
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
        [Route("DeleteDoctorDetails")]
        public async Task<IActionResult> DeleteDoctorDetails(int DoctId)
        {
            try
            {
                var DocRepo = await DoctorDetailsRepository.deleteDoctorDetails(DoctId);
                if (DocRepo > 0)
                {
                    return Ok(DocRepo);
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
