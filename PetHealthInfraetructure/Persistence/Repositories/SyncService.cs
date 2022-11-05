using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class SyncService:ISyncService
    {
        private readonly PetHealthContext _context;

        public SyncService(PetHealthContext contex)
        {
            _context = contex;
        }

        public async Task SynchroniceSet(SynchroDataDTO synchroData)
        {
            foreach (var entity in synchroData.Allergies)
            {
                Allergies temp = new Allergies()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                };
                _context.Allergies.Add(temp);
            }

            foreach (var allergyCons in synchroData.AllergyConsultation)
            {
                AllergyConsultation temp = new AllergyConsultation()
                {
                    Id = allergyCons.Id,
                    AllergyId = allergyCons.AllergyId,
                    Date = allergyCons.Date,
                    Notes = allergyCons.Notes,
                    PetId = allergyCons.PetId,
                    PersonId = allergyCons.PersonId
                };
                _context.AllergyConsultations.Add(temp);
            }

            foreach (var condition in synchroData.Condition)
            {
                Condition temp = new Condition()
                {
                    Id = condition.Id,
                    Date = condition.Date,
                    DiseaseId = condition.DiseaseId,
                    Doctor = condition.Doctor,
                    Place = condition.Place,
                    PersonId = condition.PersonId,
                    PetId = condition.PetId,
                    Notes = condition.Notes
                };
                _context.Condition.Add(temp);
            }

            foreach (var disease in synchroData.Disease)
            {
                Disease temp = new Disease()
                {
                    Id = disease.Id,
                    Name = disease.Name
                };
                _context.Diseases.Add(temp);
            }

            foreach (var drug in synchroData.Drug)
            {
                Drug temp = new Drug()
                {
                    Id = drug.Id,
                    Name = drug.Name
                };
                _context.Drugs.Add(temp);
            }

            foreach (var labTest in synchroData.LabTest)
            {
                LabTest temp = new LabTest()
                {
                    Id = labTest.Id,
                    Date = labTest.Date,
                    Doctor = labTest.Doctor,
                    Place = labTest.Place,
                    PersonId = labTest.PersonId,
                    PetId = labTest.PetId,
                    Notes = labTest.Notes,
                    Normal = labTest.Normal
                };
                _context.LabTests.Add(temp);
            }

            foreach (var medicalVisit in synchroData.MedicalVisit)
            {
                MedicalVisit temp = new MedicalVisit()
                {
                    Id = medicalVisit.Id,
                    Date = medicalVisit.Date,
                    Doctor = medicalVisit.Doctor,
                    Place = medicalVisit.Place,
                    PersonId = medicalVisit.PersonId,
                    PetId = medicalVisit.PetId,
                    Notes = medicalVisit.Notes,
                };
                _context.MedicalVisits.Add(temp);
            }

            foreach (var note in synchroData.Note)
            {
                Note temp = new Note()
                {
                    Id = note.Id,
                    Date = note.Date,
                    Doctor = note.Doctor,
                    Place = note.Place,
                    PersonId = note.PersonId,
                    PetId = note.PetId,
                    Notes = note.Notes,
                    Title = note.Title
                };
                _context.Notes.Add(temp);
            }

            foreach (var pathology in synchroData.Pathology)
            {
                Pathology temp = new Pathology()
                {
                    Id = pathology.Id,
                    Date = pathology.Date,
                    Doctor = pathology.Doctor,
                    Place = pathology.Place,
                    PersonId = pathology.PersonId,
                    PetId = pathology.PetId,
                    Notes = pathology.Notes,
                    Result = pathology.Result,
                    Title = pathology.Title
                };
                _context.Pathologies.Add(temp);
            }

            foreach (var radiology in synchroData.Radiology) 
            {
                Radiology temp = new Radiology()
                {
                    Id = radiology.Id,
                    Date = radiology.Date,
                    Doctor = radiology.Doctor,
                    Place = radiology.Place,
                    PersonId = radiology.PersonId,
                    PetId = radiology.PetId,
                    Notes = radiology.Notes,
                    Result = radiology.Result,
                    Title = radiology.Title
                };
                _context.Radiologies.Add(temp);
            }

            foreach (var surgeries in synchroData.Surgeries) 
            {
                Surgeries temp = new Surgeries()
                {
                    Id = surgeries.Id,
                    Date = surgeries.Date,
                    Doctor = surgeries.Doctor,
                    Place = surgeries.Place,
                    PersonId = surgeries.PersonId,
                    PetId = surgeries.PetId,
                    Notes = surgeries.Notes,
                    Result = surgeries.Result,
                    Title = surgeries.Title
                };
                _context.Surgeries.Add(temp);
            }

            foreach (var prescriptionDrug in synchroData.PrescriptionDrug)
            {
                PrescriptionDrug temp = new PrescriptionDrug()
                {
                    Id = prescriptionDrug.Id,
                    Date = prescriptionDrug.Date,
                    Doctor = prescriptionDrug.Doctor,
                    Place = prescriptionDrug.Place,
                    PersonId = prescriptionDrug.PersonId,
                    PetId = prescriptionDrug.PetId,
                    Notes = prescriptionDrug.Notes,
                    DrugId = prescriptionDrug.DrugId,
                };
                _context.PrescriptionDrug.Add(temp);
            }

            foreach (var vaccine in synchroData.Vaccines)
            {
                Vaccines temp = new Vaccines()
                {
                    Id = vaccine.Id,
                    Name = vaccine.Name
                };
                _context.Vaccines.Add(temp);
            }

            foreach (var vaccineConsultation in synchroData.VaccineConsultation)
            {
                VaccineConsultation temp = new VaccineConsultation()
                {
                    Id = vaccineConsultation.Id,
                    Date = vaccineConsultation.Date,
                    Doctor = vaccineConsultation.Doctor,
                    Place = vaccineConsultation.Place,
                    PetId = vaccineConsultation.PetId,
                    Notes = vaccineConsultation.Notes,
                    VaccineId = vaccineConsultation.VaccineId,
                };
                _context.VaccineConsultations.Add(temp);
            }

          _context.SaveChanges();
        }

        public async Task<SynchroDataDTO> SynchroniceGet()
        {
            throw new NotImplementedException();
        }
    }
}
