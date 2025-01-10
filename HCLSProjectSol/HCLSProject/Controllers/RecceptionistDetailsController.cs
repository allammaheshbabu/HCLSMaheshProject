using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DataAccess.Repositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionistDetailsController : ControllerBase
    {
        public IReceptionistDetailsRepository ReceptionistDetailsRepository;

        public ReceptionistDetailsController(IReceptionistDetailsRepository receptionistDetailsRepository)
        {
            ReceptionistDetailsRepository = receptionistDetailsRepository;
        }

        [HttpGet]
        [Route("GetAllReceptionistDetails")]
        public async Task<IActionResult> GetAllReceptionistDetails()
        {
            try
            {
                var ReceptionistList = await ReceptionistDetailsRepository.GetAll();
                if (ReceptionistList.Count > 0)
                {
                    return Ok(ReceptionistList);
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
        [Route("InsertReceptionistDetails")]
        public async Task<IActionResult> InsertReceptionistDetails([FromBody] ReceptionistDetails Receptionist)
        {
            try
            {
                var ReceptionistRepo = await ReceptionistDetailsRepository.insertReceptionistDetails(Receptionist);
                if (ReceptionistRepo > 0)
                {
                    return Ok(ReceptionistRepo);
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
        [Route("UpdateReceptionistDetails")]
        public async Task<IActionResult> UpdateReceptionistDetails([FromBody]  ReceptionistDetails Receptionist)
        {
            try
            {
                var ReceptionistRepo = await ReceptionistDetailsRepository.updateReceptionistDetails(Receptionist);
                if (ReceptionistRepo > 0)
                {
                    return Ok(ReceptionistRepo);
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
        [Route("DeleteReceptionistDetails")]
        public async Task<IActionResult> DeleteReceptionistDetails(int ReceptionistId)
        {
            try
            {
                var ReceptionistRepo = await ReceptionistDetailsRepository.deleteReceptionistDetails(ReceptionistId);
                if (ReceptionistRepo > 0)
                {
                    return Ok(ReceptionistRepo);
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
