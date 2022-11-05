using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class SyncService:ISyncService
    {
        private readonly PetHealthContext _context;

        public SyncService(PetHealthContext contex)
        {
            _context = contex;
        }

        public async Task SynchroniceGet(SynchroDataDTO synchroData)
        {
            foreach (var entity in synchroData.Allergies)
            {
                _context.Allergies.Add(entity);
            }

        }

        public async Task<SynchroDataDTO> SynchroniceSet()
        {
            throw new NotImplementedException();
        }
    }
}
