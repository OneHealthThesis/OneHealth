using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Entities
{
    public class Person_Pet
    {
        [Required] public string PersonId { get; set; }
        [Required] public long PetId { get; set; }
        [Required] public bool Owner { get; set; }
        [ForeignKey("PetId")] public Pet Pet { get; set; }
        [ForeignKey("PersonId")] public ApplicationUser Person { get; set; }
    }
}
