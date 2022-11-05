using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.DTOs;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Controllers
{
    [Produces("application/json")]
    [Route("api/sync"), ResponseCache(NoStore = true)]
    [ApiController]
    public class SynchronizationController : Controller
    {
        private readonly PetHealthContext _dataContext;
        private readonly ISyncService _syncService;
       public SynchronizationController(ISyncService service,PetHealthContext context)
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
            await _syncService.SynchroniceGet();
            return Ok();
        }
    }
}
