using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace dotnetapp.PetHealth.PetHealth.src.PetHealth.Core.Entities
{
    public class Allergies
    {
        [Key] public long PersonID { get; set; }
        [Required] public long PetID { get; set; }
        [ForeignKey("PetID")] public Pet Pet { get; set; }
        [ForeignKey("PersonID")] public ApplicationUser Person { get; set; }
        [Required] public DateTime Date { get; set; }
        [Required] public string Allergic { get; set; }
        public string Notes { get; set; }
    }
}
