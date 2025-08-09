using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Complaint
    {
        public ulong Id { get; set; }
        public int ComplaintFrom { get; set; }
        public int ComplaintAgainst { get; set; }
        public string Title { get; set; } = null!;
        public DateOnly ComplaintDate { get; set; }
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
