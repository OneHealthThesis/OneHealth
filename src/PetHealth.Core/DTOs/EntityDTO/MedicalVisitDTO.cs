using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class MedicalVisitDTO : IEntity<string>
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }

        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public MedicalVisitDTO(MedicalVisit medicalVisit)
        {
            Id = medicalVisit.Id;
            PersonId = medicalVisit.PersonId;
            PetId = medicalVisit.PetId;
            Date = medicalVisit.Date;
            Place = medicalVisit.Place;
            Doctor = medicalVisit.Doctor;
            Notes = medicalVisit.Notes;
        }
    }
}
