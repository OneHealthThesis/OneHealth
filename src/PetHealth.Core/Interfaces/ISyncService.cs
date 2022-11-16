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
        Task SynchronizeSet(SynchroDataDTO synchroData, CancellationToken cancellationToken);
        Task<SynchroDataDTO> SynchronizeGet(string userName, CancellationToken cancellationToken);

        Task<bool> UpdatePet(string userName,PetDTO pet, CancellationToken cancellationToken);
        Task<bool> SetInCharge(string userName, string ownerId, long petId, CancellationToken cancellationToken);
        Task<bool> DeleteInCharge(string? userName, long petId, CancellationToken cancellationToken);

        SynchroDataDTO GetStaticData();
    }
}
