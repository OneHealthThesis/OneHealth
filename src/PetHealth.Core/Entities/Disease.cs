using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Entities
{
    public class Disease
    {
        [Key] public long DiseaseId { get; set; }
        [Required] public string Name { get; set; }
    }
}
