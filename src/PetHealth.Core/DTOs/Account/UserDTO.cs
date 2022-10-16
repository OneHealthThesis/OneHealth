using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool LockoutEnabled { get; set; }
        public string RecoveryCode { get; set; }
        public DateTime? LastLogged { get; set; }
        public ICollection<RoleDTO> Roles { get; set; } = new List<RoleDTO>();
        public ICollection<PermissionDTO> Permissions { get; set; } = new List<PermissionDTO>();

    }
}
