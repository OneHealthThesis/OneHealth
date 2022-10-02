using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;

public class Traumas
{
    [Key]
    public long IdTrauma { get; set; }

   
    public DateTime Date { get; set; }

    public string Type { get; set; }


    public long IdClinicHistory { get; set; }
    [ForeignKey("IdClinicHistory")]
    public ClinicHistory ClinicHistory { get; set; }


}