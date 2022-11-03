using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHealth.Core.Entities
{
    public class Pet
    {
        [Key] public long PetID { get; set; }

        public string Name { get; set; }
        
        public  DateTime Birthday { get; set; }

        public string Breed { get; set; }

        public string Gender { get; set; }

        public string BloodType { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

    }
}
