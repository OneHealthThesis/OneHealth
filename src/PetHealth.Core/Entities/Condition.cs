using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetHealth.Core.Entities
{
    public class Condition: IEntity<string>, ISynchronizable
    {
        [Key] public string Id { get; set; }
        [Required] public string PersonId { get; set; }
        [Required] public long PetId { get; set; }
        [Required] public long DiseaseId { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        // Date when the entry was saved to de database.
        public DateTime CreatedOnDBDate { get; private set; }

        [ForeignKey("PetId")] public Pet Pet { get; set; }
        [ForeignKey("PersonId")] public ApplicationUser Person { get; set; }
        [ForeignKey("DiseaseId")] public Disease Disease{ get; set; }
    }
}