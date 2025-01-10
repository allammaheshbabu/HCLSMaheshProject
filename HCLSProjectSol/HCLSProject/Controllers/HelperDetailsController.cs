using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelperDetailsController : ControllerBase
    {
        public IHelperDetailsRepository HelperDetailsRepository;

        public HelperDetailsController(IHelperDetailsRepository helperDetailsRepository)
        {
            HelperDetailsRepository = helperDetailsRepository;
        }

        [HttpGet]
        [Route("GetAllHelperDetails")]
        public async Task<IActionResult> GetAllHelperDetails()
        {
            try
            {
                var HelperList = await HelperDetailsRepository.GetAll();
                if (HelperList.Count > 0)
                {
                    return Ok(HelperList);
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
        [Route("InsertHelperDetails")]
        public async Task<IActionResult> InsertHelperDetails([FromBody] HelperDetails Helper)
        {
            try
            {
                var HelperRepo = await HelperDetailsRepository.insertHelperDetails(Helper);
                if (HelperRepo > 0)
                {
                    return Ok(HelperRepo);
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
        [Route("UpdateHelperDetails")]
        public async Task<IActionResult> UpdateHelperDetails([FromBody] HelperDetails Helper)
        {
            try
            {
                var HelperRepo = await HelperDetailsRepository.updateHelperDetails(Helper);
                if (HelperRepo > 0)
                {
                    return Ok(HelperRepo);
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
        [Route("DeleteHelperDetails")]
        public async Task<IActionResult> DeleteEmployee(int HelperId)
        {
            try
            {
                var HelperRepo = await HelperDetailsRepository.deleteHelperDetails(HelperId);     
                if (HelperRepo > 0)
                {
                    return Ok(HelperRepo);
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
