using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.DTOs;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.WebUtilities;

namespace PetHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PetController : DataControllerBase<Pet, PetDTO, long>
    {
        public PetController(IDataService<IPetHealthContext> dataService, ICrudHandler<Pet,PetDTO,long> dataHandler = null)
            : base(dataService, dataHandler)
        {
        }
    }
}
