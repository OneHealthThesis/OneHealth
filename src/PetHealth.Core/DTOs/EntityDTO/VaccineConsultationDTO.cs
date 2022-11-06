using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class VaccineConsultationDTO
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }

        public DateTime Date { get; set; }
        public long VaccineId { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public VaccineConsultationDTO(VaccineConsultation vaccineConsultation)
        {
            Id  = vaccineConsultation.Id;
            PersonId = vaccineConsultation.PersonId;
            PetId = vaccineConsultation.PetId;
            Date = vaccineConsultation.Date;
            VaccineId = vaccineConsultation.VaccineId;
            Place = vaccineConsultation.Place;
            Doctor = vaccineConsultation.Doctor;
            Notes = vaccineConsultation.Notes;
        }
    }
}
