using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.DTOs
{
    public class CreatePersonDTO
    {
        public long IdUser { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Ethnicity { get; set; }

        public string Address { get; set; }
    }

    public class PersonDTO
    {
        public long IdUser { get; set; }

        public bool IsAdmin { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        //[Required] 
        //public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string Ethnicity { get; set; }

        public string Address { get; set; }

        public string Version { get; set; }
    }
}
