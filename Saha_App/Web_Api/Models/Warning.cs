using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Warning
    {
        public ulong Id { get; set; }
        public int WarningTo { get; set; }
        public int WarningBy { get; set; }
        public string? Subject { get; set; }
        public DateOnly WarningDate { get; set; }
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
