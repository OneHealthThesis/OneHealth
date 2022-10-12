using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;

public class Pet
{
    [Key] public long IdPet { get; set; }

    [Required,
     StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
    public string Name { get; set; }

    public string Breed { get; set; }
    public DateTime BirthDate { get; set; }
    [Required] public Gender Gender { get; set; }
    public string Color { get; set; }
    public string Marks { get; set; }
    public string Tattos { get; set; }
    public int Version { get; set; }
}