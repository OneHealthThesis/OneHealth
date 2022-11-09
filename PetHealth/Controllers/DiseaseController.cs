using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.WebUtilities;

namespace PetHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DiseaseController : DataControllerBase<Disease, LongIdNameDTO, long>
    {
        public DiseaseController(IDataService<IPetHealthContext> dataService, ICrudHandler<Disease,LongIdNameDTO,long> dataHandler = null)
            : base(dataService, dataHandler)
        {
        }
    }
}
