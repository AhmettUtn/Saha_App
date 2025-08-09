using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class UserLead
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong LeadId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Lead Lead { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
