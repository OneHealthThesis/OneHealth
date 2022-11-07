using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHealth.Core.Entities
{
    public class Vaccines: ISynchronizable, IEntity<long>, ILongIdName
    {
        [Key]
        [Column("VaccineId")]
        public long Id { get; set; }
        [Required] public string Name { get; set; }

        // Date when the entry was saved to the database.
        public DateTime CreatedOnDBDate { get; private set; }
    }
}
