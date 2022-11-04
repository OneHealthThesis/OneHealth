
using PetHealth.Core.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetHealth.Core.Entities
{
    public class Condition: IEntity<string>
    {
        [Key] public string Id { get; set; }
        [Required] public string PersonId { get; set; }
        [Required] public long PetId { get; set; }
        [Required] public long DiseaseId { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        [ForeignKey("PetId")] public Pet Pet { get; set; }
        [ForeignKey("PersonId")] public ApplicationUser Person { get; set; }
        [ForeignKey("DiseaseId")] public Disease Disease{ get; set; }
    }
}