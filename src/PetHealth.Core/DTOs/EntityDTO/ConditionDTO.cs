using PetHealth.Core.Interfaces.CoreInterfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;


namespace PetHealth.Core.DTOs.EntityDTO
{
    public class ConditionDTO
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }
        public long DiseaseId { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public ConditionDTO(Condition condition)
        {
            Id = condition.Id;
            PersonId = condition.PersonId;
            PetId = condition.PetId;
            DiseaseId = condition.DiseaseId;
            Date = condition.Date;
            Place = condition.Place;
            Doctor = condition.Doctor;
            Notes = condition.Notes;
        }
    }
}