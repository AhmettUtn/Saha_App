using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Milestone
    {
        public ulong Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateOnly? DueDate { get; set; }
        public DateOnly? StartDate { get; set; }
        public double Cost { get; set; }
        public string? Progress { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
