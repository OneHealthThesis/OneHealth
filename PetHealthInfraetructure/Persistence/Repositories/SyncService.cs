using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PetHealth.Core.DTOs;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class SyncService:ISyncService
    {
        private readonly PetHealthContext _context;
        private readonly IMapper _mapper;

        public SyncService(PetHealthContext contex, IMapper mapper)
        {
            _context = contex;
            _mapper = mapper;
        }

        public async Task SynchroniceSet(SynchroDataDTO synchroData)
        {
            foreach (var entity in synchroData.Allergies)
            {
                Allergies temp = this._mapper.Map<Allergies>(entity);
                _context.Allergies.Add(temp);
            }

            foreach (var allergyCons in synchroData.AllergyConsultation)
            {
                AllergyConsultation temp = this._mapper.Map<AllergyConsultation>(allergyCons);
                _context.AllergyConsultations.Add(temp);
            }

            foreach (var condition in synchroData.Condition)
            {
                Condition temp = this._mapper.Map<Condition>(condition);
                _context.Condition.Add(temp);
            }

            foreach (var disease in synchroData.Disease)
            {
                Disease temp = this._mapper.Map<Disease>(disease);
                _context.Diseases.Add(temp);
            }

            foreach (var drug in synchroData.Drug)
            {
                Drug temp = this._mapper.Map<Drug>(drug);
                _context.Drugs.Add(temp);
            }

            foreach (var labTest in synchroData.LabTest)
            {
                LabTest temp = this._mapper.Map<LabTest>(labTest);
                _context.LabTests.Add(temp);
            }

            foreach (var medicalVisit in synchroData.MedicalVisit)
            {
                MedicalVisit temp = this._mapper.Map<MedicalVisit>(medicalVisit);
                _context.MedicalVisits.Add(temp);
            }

            foreach (var note in synchroData.Note)
            {
                Note temp = this._mapper.Map<Note>(note);
                _context.Notes.Add(temp);
            }

            foreach (var pathology in synchroData.Pathology)
            {
                Pathology temp = this._mapper.Map<Pathology>(pathology);
                _context.Pathologies.Add(temp);
            }

            foreach (var radiology in synchroData.Radiology) 
            {
                Radiology temp = this._mapper.Map<Radiology>(radiology);
                _context.Radiologies.Add(temp);
            }

            foreach (var surgeries in synchroData.Surgeries) 
            {
                Surgeries temp = this._mapper.Map<Surgeries>(surgeries);
                _context.Surgeries.Add(temp);
            }

            foreach (var prescriptionDrug in synchroData.PrescriptionDrug)
            {
                PrescriptionDrug temp = this._mapper.Map<PrescriptionDrug>(prescriptionDrug);
                _context.PrescriptionDrug.Add(temp);
            }

            foreach (var vaccine in synchroData.Vaccines)
            {
                Vaccines temp = this._mapper.Map<Vaccines>(vaccine);
                _context.Vaccines.Add(temp);
            }

            foreach (var vaccineConsultation in synchroData.VaccineConsultation)
            {
                VaccineConsultation temp = this._mapper.Map<VaccineConsultation>(vaccineConsultation);
                _context.VaccineConsultations.Add(temp);
            }

          _context.SaveChanges();
        }

        public async Task<SynchroDataDTO> SynchroniceGet()
        {
            DateTime dateUpdate = DateTime.MinValue;
           
            SynchroDataDTO synchroDataDTO = new SynchroDataDTO();

            foreach (var item in _context.Allergies.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Allergies.Add(this._mapper.Map<LongIdNameDTO>(item));
            
            foreach (var item in _context.Drugs.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Drug.Add(this._mapper.Map<LongIdNameDTO>(item));
            
            foreach (var item in _context.Diseases.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Disease.Add(this._mapper.Map<LongIdNameDTO>(item));
            
            foreach (var item in _context.Vaccines.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Vaccines.Add(this._mapper.Map<LongIdNameDTO>(item));

            foreach (var item in _context.AllergyConsultations.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.AllergyConsultation.Add(this._mapper.Map<AllergyConsultationDTO>(item));

            foreach (var item in _context.Condition.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Condition.Add(this._mapper.Map<ConditionDTO>(item));

            foreach (var item in _context.LabTests.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.LabTest.Add(this._mapper.Map<LabTestDTO>(item));

            foreach (var item in _context.MedicalVisits.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.MedicalVisit.Add(this._mapper.Map<MedicalVisitDTO>(item));

            foreach (var item in _context.Notes.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Note.Add(this._mapper.Map<NoteDTO>(item));

            foreach (var item in _context.Pathologies.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Pathology.Add(this._mapper.Map<PathologyDTO>(item));

            foreach (var item in _context.PrescriptionDrug.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.PrescriptionDrug.Add(this._mapper.Map<PrescriptionDrugDTO>(item));

            foreach (var item in _context.Radiologies.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Radiology.Add(this._mapper.Map<RadiologyDTO>(item));

            foreach (var item in _context.Surgeries.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Surgeries.Add(this._mapper.Map<SurgeriesDTO>(item));

            foreach (var item in _context.VaccineConsultations.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.VaccineConsultation.Add(this._mapper.Map<VaccineConsultationDTO>(item));

            return synchroDataDTO;
        }
    }
}
