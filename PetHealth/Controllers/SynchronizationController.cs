using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.DTOs;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Controllers
{
    [Produces("application/json")]
    [Route("api/sync"), ResponseCache(NoStore = true)]
    [ApiController]
    public class SynchronizationController : ControllerBase
    {
        private readonly PetHealthContext _dataContext;
        private readonly ISyncService _syncService;
       public SynchronizationController(ISyncService service, PetHealthContext context)
       {
           _syncService = service;
           _dataContext = context;
       }


        [HttpPost]
        [Route("set")]
        public async Task<IActionResult> SynchroniceSet([
            FromBody]SynchroDataDTO synchroDataDTO
            )

        {
            await _syncService.SynchroniceSet(synchroDataDTO);
            return Ok();
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> SynchroniceGet(
            [FromQuery] IdDTO idDto)
        {
            ApplicationUser user= _dataContext.Persons.Find(idDto.Id);
            return Ok(await _syncService.SynchroniceGet(user));
        }

        [HttpPost]
        [Route("update/pet")]
        public async Task<IActionResult> UpdatePet(
            [FromBody]PetDTO petDto
        )
        {
            await _syncService.UpdatePet(petDto);
            return Ok();
        }

        [HttpPut]
        [Route("set/incharge")]
        public async Task<IActionResult> SetIncharge(
            [FromQuery] string personId,
            [FromQuery] long petId
                )
        {
            await _syncService.SetInCharge(personId, petId);
            return Ok();
        }
    }
}
