using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Entities
{
    public class ApplicationUser: IdentityUser<string>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

    }
}
