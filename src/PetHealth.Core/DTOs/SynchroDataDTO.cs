using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs
{
    public class SynchroDataDTO
    {
        public List<LongIdNameDTO> Allergies { get; set; }
        public List<AllergyConsultationDTO> AllergyConsultation { get; set; }
        public List<ConditionDTO> Condition { get; set; }
        public List<LongIdNameDTO> Disease { get; set; }
        public List<LongIdNameDTO> Drug { get; set; }
        public List<LabTestDTO> LabTest { get; set; }
        public List<MedicalVisitDTO> MedicalVisit { get; set; }
        public List<NoteDTO> Note { get; set; }
        public List<PathologyDTO> Pathology { get; set; }
        public List<PrescriptionDrugDTO> PrescriptionDrug { get; set; }
        public List<RadiologyDTO> Radiology { get; set; }
        public List<SurgeriesDTO> Surgeries { get; set; }
        public List<VaccineConsultationDTO> VaccineConsultation { get; set; }
        public List<LongIdNameDTO> Vaccines { get; set; }
    }
}
