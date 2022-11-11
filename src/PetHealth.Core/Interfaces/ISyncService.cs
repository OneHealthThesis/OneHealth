using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface ISyncService
    {
       Task SynchroniceSet(SynchroDataDTO synchroData);
       Task<SynchroDataDTO> SynchroniceGet(ApplicationUser applicationUser);

       Task UpdatePet(PetDTO pet);
    }
}
