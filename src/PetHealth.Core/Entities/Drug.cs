using System.ComponentModel.DataAnnotations;


namespace PetHealth.Core.Entities
{
    public class Drug
    {
        [Key] public long DrugId { get; set; }
        [Required] public string Name{ get; set; }
    }
}
