using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class AllergyConsultationDTO
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }
        public DateTime Date { get; set; }
        public long AllergyId { get; set; }
        public string Notes { get; set; }

        public AllergyConsultationDTO(AllergyConsultation allergyConsultation)
        {
            Id = allergyConsultation.Id;
            PersonId = allergyConsultation.PersonId;
            PetId = allergyConsultation.PetId;
            Date = allergyConsultation.Date;
            AllergyId = allergyConsultation.AllergyId;
            Notes = allergyConsultation.Notes;
        }
    }
}
