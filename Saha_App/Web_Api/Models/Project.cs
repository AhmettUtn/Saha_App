using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Project
    {
        public ulong Id { get; set; }
        public string ProjectName { get; set; } = null!;
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? ProjectImage { get; set; }
        public int? Budget { get; set; }
        public int ClientId { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } = null!;
        public string? EstimatedHrs { get; set; }
        public string? Tags { get; set; }
        public ulong CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
