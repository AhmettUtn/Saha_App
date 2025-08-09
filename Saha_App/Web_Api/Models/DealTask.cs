using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class DealTask
    {
        public ulong Id { get; set; }
        public ulong DealId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Priority { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Deal Deal { get; set; } = null!;
    }
}
