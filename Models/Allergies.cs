using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models;

public class Allergies
{
    public long IdClinicHistory { get; set; }
    public long IdDrug { get; set; }
    [ForeignKey("IdClinicHistory")] public ClinicHistory ClinicHistory { get; set; }
    [ForeignKey("IdDrug")] public Drug Drug { get; set; }
}