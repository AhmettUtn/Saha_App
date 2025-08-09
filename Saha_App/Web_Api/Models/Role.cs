using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Role
    {
        public Role()
        {
            ModelHasRoles = new HashSet<ModelHasRole>();
            Permissions = new HashSet<Permission>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string GuardName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<ModelHasRole> ModelHasRoles { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
