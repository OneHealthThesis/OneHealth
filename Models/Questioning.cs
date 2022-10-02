using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;

public class Questioning
{
    [Key] public long IdQuestioning { get; set; }
    public string Appetite { get; set; }
    public string Drink { get; set; }
    public bool Cough { get; set; }
    public bool Sneezing { get; set; }
    public bool Vomit { get; set; }
    public string IntestinalMovement { get; set; }
    public string Urine { get; set; }

}