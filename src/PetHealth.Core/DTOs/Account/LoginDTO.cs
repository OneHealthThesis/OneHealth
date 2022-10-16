using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.DTOs
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Browser { get; set; }
        public string RealFirstName { get; set; }
        public string RealLastName { get; set; }
        public string RealEmail { get; set; }
    }
}
