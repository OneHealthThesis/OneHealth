using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;

public class Consultation:Service
{
   
    [Required]public long IdClinicHistory { get; set; }

    public long IdQuestioning { get; set; }

    public long IdPhysicalTest { get; set; }

    [Required] public long IdVeterinary { get; set; }

    public string Procedure { get; set; }
    
    [Required] public DateTime Date { get; set; }

    public string Suffering { get; set; }

    public string Reason { get; set; }
   
    

    [ForeignKey("IdVeterinary")]
    public Person Veterinary { get; set; }

    

    [ForeignKey("IdQuestioning")]
    public Questioning Questioning { get; set; }

    [ForeignKey("IdPhysicalTest")]
    public PhysicalTest PhysicalTest { get; set; }

    [ForeignKey("IdClinicHistory")]
    public ClinicHistory ClinicHistory { get; set; }
    


}