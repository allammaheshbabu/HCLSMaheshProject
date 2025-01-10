using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DataAccess.Repositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorSpecializationController : ControllerBase
    {
        public IDoctorSpecializationRepository DoctorSpecializationRepository;

        public DoctorSpecializationController(IDoctorSpecializationRepository doctorSpecializationRepository)
        {
            DoctorSpecializationRepository = doctorSpecializationRepository;
        }

        [HttpGet]
        [Route("GetAllDoctorSpecializations")]
        public async Task<IActionResult> GetAllDoctorSpecializations()
        {
            try
            {
                var DocSpclList = await DoctorSpecializationRepository.GetAll();
                if (DocSpclList.Count > 0)
                {
                    return Ok(DocSpclList);
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
        [Route("InsertDoctorSpecialization")]
        public async Task<IActionResult> InsertDoctorSpecialization([FromBody] DoctorSpecialization DocSpclDetl)
        {
            try
            {
                var DoctSpclRepo = await DoctorSpecializationRepository.insertDoctorSpecialization(DocSpclDetl);
                if (DoctSpclRepo > 0)
                {
                    return Ok(DoctSpclRepo);
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
        [Route("UpdateDoctorSpecialization")]
        public async Task<IActionResult> UpdateDoctorSpecialization([FromBody] DoctorSpecialization DocSpclDetl)
        {
            try
            {
                var DoctSpclRepo = await DoctorSpecializationRepository.updateDoctorSpecialization(DocSpclDetl);
                if (DoctSpclRepo > 0)
                {
                    return Ok(DoctSpclRepo);
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
        [Route("DeleteDoctorSpecialization")]
        public async Task<IActionResult> DeleteDoctorSpecialization(int DoctSpclId)
        {
            try
            {
                var DocSpclRepo = await DoctorSpecializationRepository.deleteDoctorSpecialization(DoctSpclId);
                if (DocSpclRepo > 0)
                {
                    return Ok(DocSpclRepo);
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
