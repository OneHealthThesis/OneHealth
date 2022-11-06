using PetHealth.Core.Interfaces.CoreInterfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class NoteDTO
    {
        public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }

        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }

        public NoteDTO(Note note)
        {
            Id = note.Id;
            PersonId = note.PersonId;
            PetId = note.PetId;
            Date = note.Date;
            Title = note.Title;
            Place = note.Place;
            Doctor = note.Doctor;
            Notes = note.Notes;
        }
    }
}
