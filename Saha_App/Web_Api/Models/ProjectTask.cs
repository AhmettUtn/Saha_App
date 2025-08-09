using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ProjectTask
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int EstimatedHrs { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string Priority { get; set; } = null!;
        public string? PriorityColor { get; set; }
        public string? AssignTo { get; set; }
        public int ProjectId { get; set; }
        public int MilestoneId { get; set; }
        public int StageId { get; set; }
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public int IsFavourite { get; set; }
        public int IsComplete { get; set; }
        public DateOnly? MarkedAt { get; set; }
        public string Progress { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
