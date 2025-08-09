using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Job
    {
        public ulong Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Requirement { get; set; }
        public int Branch { get; set; }
        public int Category { get; set; }
        public string? Skill { get; set; }
        public int? Position { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? Status { get; set; }
        public string? Applicant { get; set; }
        public string? Visibility { get; set; }
        public string? Code { get; set; }
        public string? CustomQuestion { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
