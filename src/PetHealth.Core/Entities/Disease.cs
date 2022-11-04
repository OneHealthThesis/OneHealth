using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;

namespace PetHealth.Core.Entities
{
    public class Disease: IEntity<long>
    {
        [Key][Column("DiseaseId")] public long Id { get; set; }
        [Required] public string Name { get; set; }
    }
}
