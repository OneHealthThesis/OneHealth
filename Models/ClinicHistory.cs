using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace dotnetapp.Models;

public class ClinicHistory
{
    [Key]
    public long IdClinicHistory { get; set; }

    public long IdPet { get; set; }

    public string BloodType { get; set; }
    
    public string VaccineSchedule { get; set; }

    [ForeignKey("IdPet")]
    public Pet Pet { get; set; }
    public virtual ICollection<Allergies> Allergies { get; set; }

    public virtual ICollection<Surgeries> Surgeries { get; set; }

    public virtual ICollection<Traumas> Traumas { get; set; }

    public virtual ICollection<Transfusions> Transfusions { get; set; }

    public virtual ICollection<Consultation> Consultations{ get; set; }
}