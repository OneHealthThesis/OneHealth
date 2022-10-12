using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;

public class Transfusions
{
    [Key]
    public long IdTransfusion { get; set; }
    public DateTime Date { get; set; }
    public string Causes { get; set; }
    public long IdClinicHistory { get; set; }
    [ForeignKey("IdClinicHistory")]
    public ClinicHistory ClinicHistory { get; set; }

}