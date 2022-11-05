﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface ISyncService
    {
       Task SynchroniceGet(SynchroDataDTO synchroData);
       Task<SynchroDataDTO> SynchroniceSet();
    }
}