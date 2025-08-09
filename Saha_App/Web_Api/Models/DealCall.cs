using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class DealCall
    {
        public ulong Id { get; set; }
        public ulong DealId { get; set; }
        public string Subject { get; set; } = null!;
        public string CallType { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public int UserId { get; set; }
        public string? Description { get; set; }
        public string? CallResult { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Deal Deal { get; set; } = null!;
    }
}
