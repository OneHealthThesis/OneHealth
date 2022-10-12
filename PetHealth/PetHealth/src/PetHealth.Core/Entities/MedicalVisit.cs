using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.PetHealth.PetHealth.src.PetHealth.Core.Entities
{
    public class MedicalVisit
    {
        [ForeignKey(""),Key] public long PersonID { get; set; }
        [ForeignKey("")] public long PetID { get; set; }
        [Required]public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }
    }
}
