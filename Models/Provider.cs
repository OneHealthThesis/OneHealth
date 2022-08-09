using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class Provider : Person
{
    [Required]
    public string Speciality { get; set; }
    [Required] public string workplace { get; set; }

    public bool IsVeterinary { get; set; }

}