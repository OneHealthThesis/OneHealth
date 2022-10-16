using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace dotnetapp.PetHealth.PetHealth.src.PetHealth.Core.Entities
{
    public class Vaccines
    {
        [Key] public long VaccineId { get; set; }
        [Required] public string Name { get; set; }
    }
}
