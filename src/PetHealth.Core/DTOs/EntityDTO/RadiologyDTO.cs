using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetHealth.Core.Entities;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class RadiologyDTO
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

    }
}
