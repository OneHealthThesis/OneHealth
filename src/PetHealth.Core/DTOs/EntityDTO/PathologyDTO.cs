using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class PathologyDTO
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }

        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Result { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public PathologyDTO(Pathology pathology)
        {
            Id = pathology.Id;
            PersonId = pathology.PersonId;
            PetId = pathology.PetId;
            Date = pathology.Date;
            Title = pathology.Title;
            Result = pathology.Result;
            Place = pathology.Place;
            Doctor = pathology.Doctor;
            Notes = pathology.Notes;
        }
    }
}
