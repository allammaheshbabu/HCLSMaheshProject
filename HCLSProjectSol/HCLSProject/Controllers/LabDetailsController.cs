using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabDetailsController : ControllerBase
    {
        public ILabDetailsRepository LabDetailsRepository;

        public LabDetailsController(ILabDetailsRepository labDetailsRepository)
        {
            LabDetailsRepository = labDetailsRepository;
        }

        [HttpGet]
        [Route("GetAllLabDetails")]
        public async Task<IActionResult> GetAllLabDetails()
        {
            try
            {
                var LabList = await LabDetailsRepository.GetAll();
                if (LabList.Count > 0)
                {
                    return Ok(LabList);
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
        [Route("InsertLabDetails")]
        public async Task<IActionResult> InsertLabDetails([FromBody] LabDetails Lab)
        {
            try
            {
                var LabRepo = await LabDetailsRepository.insertLabDetails(Lab);
                if (LabRepo > 0)
                {
                    return Ok(LabRepo);
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
        [Route("UpdateLabDetails")]
        public async Task<IActionResult> UpdateLabDetails([FromBody]  LabDetails Lab)
        {
            try
            {
                var LabRepo = await LabDetailsRepository.updateLabDetails(Lab);
                if (LabRepo > 0)
                {
                    return Ok(LabRepo);
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
        [Route("DeleteLabDetails")]
        public async Task<IActionResult> DeleteLabDetails(int LabId)     
        {
            try
            {
                var LabRepo = await LabDetailsRepository.deleteLabDetails(LabId);
                if (LabRepo > 0)
                {
                    return Ok(LabRepo);
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
