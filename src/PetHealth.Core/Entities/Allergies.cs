using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Entities
{
    public class Allergies: IEntity<long>
    {
        [Key][Column("AllergyId")] public long Id { get; set; }
        [Required] public string Name{ get; set; }
        
    }
}
