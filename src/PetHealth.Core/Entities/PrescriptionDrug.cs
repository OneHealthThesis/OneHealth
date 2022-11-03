using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Entities
{
    public class PrescriptionDrug
    {
        [Key] public string Id { get; set; }
        [Required] public string PersonId { get; set; }
        [Required] public long PetId { get; set; }
        [ForeignKey("PetId")] public Pet Pet { get; set; }
        [ForeignKey("PersonId")] public ApplicationUser Person { get; set; }
        [Required] public DateTime Date { get; set; }
        [Required] public long DrugId { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }
        [ForeignKey("DrugId")] private Drug Drug { get; set;}
    }
}
