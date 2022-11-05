using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHealth.Core.Entities
{
    public class Drug: IEntity<long>, ISynchronizable
    {
        [Key][Column("DrugId")] public long Id { get; set; }
        [Required] public string Name{ get; set; }

        // Date when the entry was saved to de database.
        public DateTime CreatedOnDBDate { get; private set; }
    }
}
