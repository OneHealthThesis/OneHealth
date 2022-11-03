using System.ComponentModel.DataAnnotations;


namespace PetHealth.Core.Entities
{
    public class Vaccines
    {
        [Key] public long VaccineId { get; set; }
        [Required] public string Name { get; set; }
    }
}
