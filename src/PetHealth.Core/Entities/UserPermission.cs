using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Entities
{
    public class UserPermission
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int PermissionId { get; set; }

        public Permission Permission { get; set; }
    }
}
