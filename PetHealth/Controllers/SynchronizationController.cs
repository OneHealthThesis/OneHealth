using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.DTOs;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]"), ResponseCache(NoStore = true)]
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
        [Route("get")]
        public async Task<IActionResult> SynchroniceGet([
            FromBody]SynchroDataDTO synchroDataDTO
            )

        {
            await _syncService.SynchroniceGet(synchroDataDTO);
            return Ok();
        }
    }
}
