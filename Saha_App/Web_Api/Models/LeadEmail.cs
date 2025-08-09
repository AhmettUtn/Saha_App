using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class LeadEmail
    {
        public ulong Id { get; set; }
        public ulong LeadId { get; set; }
        public string To { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Lead Lead { get; set; } = null!;
    }
}
