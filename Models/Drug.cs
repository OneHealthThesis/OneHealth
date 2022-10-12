using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class Drug
{
    [Key] public long IdDrug { get; set; }

    [Required] public string Name { get; set; }

}