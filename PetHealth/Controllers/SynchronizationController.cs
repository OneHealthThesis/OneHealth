using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.DTOs;
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
        private readonly IPetHealthContext _dataContext;
        private readonly ISyncService _syncService;
       public SynchronizationController(ISyncService service, IPetHealthContext context)
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

        [HttpPost]
        [Route("get")]
        public async Task<IActionResult> SynchroniceGet(
           )
        {
            
            return Ok(await _syncService.SynchroniceGet(null));
        }
    }
}
