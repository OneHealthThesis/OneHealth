using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.DTOs;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class SyncService:ISyncService
    {
        private readonly IPetHealthContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public SyncService(IPetHealthContext contex, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _context = contex;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task SynchroniceSet(SynchroDataDTO synchroData, CancellationToken cancellationToken)
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

          await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<SynchroDataDTO> SynchroniceGet(string userName, CancellationToken cancellationToken)
        {
            var user = await this._userManager.FindByNameAsync(userName);

            DateTime? dateUpdate = user.LastSynchronized != null ? user.LastSynchronized  :DateTime.MinValue;
            var pets = _context.PersonHasPet
                .AsNoTracking()
                .Where(data => data.PersonId == user.Id).Select(p => p.PetId).ToList();
            SynchroDataDTO synchroDataDTO = new SynchroDataDTO();

            foreach (var item in _context.Allergies.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Allergies.Add(this._mapper.Map<LongIdNameDTO>(item));
            
            foreach (var item in _context.Drugs.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Drug.Add(this._mapper.Map<LongIdNameDTO>(item));
            
            foreach (var item in _context.Diseases.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Disease.Add(this._mapper.Map<LongIdNameDTO>(item));
            
            foreach (var item in _context.Vaccines.Where(data => data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Vaccines.Add(this._mapper.Map<LongIdNameDTO>(item));

            foreach (var item in _context.AllergyConsultations.Where(data =>data.PersonId !=user.Id && pets.Contains(data.PetId) &&  data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.AllergyConsultation.Add(this._mapper.Map<AllergyConsultationDTO>(item));

            foreach (var item in _context.Condition.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Condition.Add(this._mapper.Map<ConditionDTO>(item));

            foreach (var item in _context.LabTests.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.LabTest.Add(this._mapper.Map<LabTestDTO>(item));

            foreach (var item in _context.MedicalVisits.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.MedicalVisit.Add(this._mapper.Map<MedicalVisitDTO>(item));

            foreach (var item in _context.Notes.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Note.Add(this._mapper.Map<NoteDTO>(item));

            foreach (var item in _context.Pathologies.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Pathology.Add(this._mapper.Map<PathologyDTO>(item));

            foreach (var item in _context.PrescriptionDrug.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.PrescriptionDrug.Add(this._mapper.Map<PrescriptionDrugDTO>(item));

            foreach (var item in _context.Radiologies.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Radiology.Add(this._mapper.Map<RadiologyDTO>(item));

            foreach (var item in _context.Surgeries.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.Surgeries.Add(this._mapper.Map<SurgeriesDTO>(item));

            foreach (var item in _context.VaccineConsultations.Where(data => data.PersonId != user.Id && pets.Contains(data.PetId) && data.CreatedOnDBDate > dateUpdate))
                synchroDataDTO.VaccineConsultation.Add(this._mapper.Map<VaccineConsultationDTO>(item));
            user.LastSynchronized = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
            return synchroDataDTO;
        }

        public async Task<bool> UpdatePet(PetDTO pet, CancellationToken cancellationToken)
        {
            Pet toUpdate = _context.Pets.Find(pet.Id);
            if (toUpdate != null)
            {
                toUpdate.Birthday = pet.Birthday;
                toUpdate.Gender = pet.Gender;
                toUpdate.Name = pet.Name;
                toUpdate.BloodType = pet.BloodType;
                toUpdate.Breed = pet.Breed;
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }

            return false;
        }


        public async Task<bool> SetInCharge(string userName, string ownerId, long petId, CancellationToken cancellationToken)
        {
            var user = await this._userManager.FindByNameAsync(userName);
            var check = _context.PersonHasPet.Any(x => x.PersonId == ownerId && x.PetId == petId && x.Owner == true) &&
                        !_context.PersonHasPet.Any(x => x.PersonId == user.Id && x.PetId == petId );
            if (check)
            {
                _context.PersonHasPet.Add(new(){PersonId = user.Id,PetId = petId,Owner = false});
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }
    }
}
