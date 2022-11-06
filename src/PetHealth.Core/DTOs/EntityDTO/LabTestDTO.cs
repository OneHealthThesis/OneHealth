using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class LabTestDTO : IEntity<string>
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }
        public DateTime Date { get; set; }
        public string Test { get; set; }
        public string Result { get; set; }
        public bool Normal { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public LabTestDTO(LabTest labTest)
        {
            Id = labTest.Id;
            PersonId = labTest.PersonId;
            PetId = labTest.PetId;
            Date = labTest.Date;
            Test = labTest.Test;
            Result = labTest.Result;
            Normal = labTest.Normal;
            Place = labTest.Place;
            Doctor = labTest.Doctor;
            Notes = labTest.Notes;
        }
    }
}
