using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Entities
{
    public class AllergyConsultation
    {
        [Key] public string Id { get; set; }
        [Required] public string PersonId { get; set; }
        [Required] public long PetId { get; set; }

        [Required] public DateTime Date { get; set; }
        [Required] public long AllergyId { get; set; }
        public string Notes { get; set; }

        [ForeignKey("PetId")] public Pet Pet { get; set; }
        [ForeignKey("PersonId")] public ApplicationUser Person { get; set; }
    }
}

