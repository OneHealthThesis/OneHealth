using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models;



public class PrescriptionDrug
{
    [Key] public long Id { get; set; }
    [Required] public long IdPet { get; set; }
    [Required] public long IdDrug { get; set; }
    [Required] public long IdVeterinary { get; set; }
    [Required] public long IdConsultation { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; } 
    public string EndOfExhibitionReason { get; set; }
    public string Resupply { get; set; }
    public int Amount   { get; set; }   
    public string SupplyDays    { get; set; }
    public string Signature { get; set; }
    public string Dose { get; set; }
    public int Number { get; set; }

    [ForeignKey("IdPet")]
    public Pet Pet { get; set; }

    [ForeignKey("IdDrug")]
    public Drug Drug { get; set; }

    [ForeignKey("IdVeterinary")]
    public Provider Veterinary { get; set; }

    [ForeignKey("IdConsultation")]
    public Consultation Consultation { get; set; }




}