using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class AllergyConsultationDTO
    {
         public string Id { get; set; }
        public string PersonId { get; set; }
        public long PetId { get; set; }
        public DateTime Date { get; set; }
        public long AllergyId { get; set; }
        public string Notes { get; set; }
    }
}
