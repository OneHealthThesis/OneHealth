using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Interfaces
{
    public interface ISynchronizable
    {
        DateTime CreatedOnDBDate { get; }
    }
}
