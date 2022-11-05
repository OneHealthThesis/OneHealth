using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs
{
    public class SynchroDataDTO
    {
        public List<Allergies> Allergies { get; set; }
        public List<AllergyConsultation> AllergyConsultation { get; set; }
        public List<Condition> Condition { get; set; }
        public List<Disease> Disease { get; set; }
        public List<Drug> Drug { get; set; }
        public List<LabTest> LabTest { get; set; }
        public List<MedicalVisit> MedicalVisit { get; set; }
        public List<Note> Note { get; set; }
        public List<Pathology> Pathology { get; set; }
        public List<PrescriptionDrug> PrescriptionDrug { get; set; }
        public List<Radiology> Radiology { get; set; }
        public List<Surgeries> Surgeries { get; set; }
        public List<VaccineConsultation> VaccineConsultation { get; set; }
        public List<Vaccines> Vaccines { get; set; }
    }
}
