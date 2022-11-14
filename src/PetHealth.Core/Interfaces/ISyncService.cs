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
       Task SynchroniceSet(SynchroDataDTO synchroData, CancellationToken cancellationToken);
       Task<SynchroDataDTO> SynchroniceGet(string userName, CancellationToken cancellationToken);

       Task<bool> UpdatePet(PetDTO pet, CancellationToken cancellationToken);
       Task<bool> SetInCharge(string userName, string inChargeId, long petId, CancellationToken cancellationToken);
    }
}
