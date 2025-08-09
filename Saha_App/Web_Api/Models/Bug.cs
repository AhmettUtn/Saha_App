using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Bug
    {
        public ulong Id { get; set; }
        public int BugId { get; set; }
        public int ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Priority { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? DueDate { get; set; }
        public string Description { get; set; } = null!;
        public string? Status { get; set; }
        public string Order { get; set; } = null!;
        public string? AssignTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
