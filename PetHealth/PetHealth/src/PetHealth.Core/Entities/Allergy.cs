using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.PetHealth.PetHealth.src.PetHealth.Core.Entities
{
    public class Allergy
    {
        [ForeignKey(""), Key] public long PersonID { get; set; }
        [ForeignKey("")] public long PetID { get; set; }
        [Required] public DateTime Date { get; set; }
        [Required] public string AllergicTo { get; set; }
        public string Notes { get; set; }
    }
}
