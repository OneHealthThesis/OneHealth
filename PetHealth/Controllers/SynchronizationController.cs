using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Controllers
{
    [Produces("application/json")]
    [Route("api/"), ResponseCache(NoStore = true)]
    [ApiController]
    public class SynchronizationController : Controller
    {
        private readonly PetHealthContext _dataContext;

    }
}
