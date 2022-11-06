using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class PrescriptionDrugDTO
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }

        public DateTime Date { get; set; }
        public long DrugId { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public PrescriptionDrugDTO(PrescriptionDrug prescriptionDrug)
        {
            Id = prescriptionDrug.Id;
            PersonId = prescriptionDrug.PersonId;
            PetId = prescriptionDrug.PetId;
            Date = prescriptionDrug.Date;
            DrugId = prescriptionDrug.DrugId;
            Place = prescriptionDrug.Place;
            Doctor = prescriptionDrug.Doctor;
            Notes = prescriptionDrug.Notes;
        }
    }
}
