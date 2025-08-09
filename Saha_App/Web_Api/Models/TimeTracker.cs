using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class TimeTracker
    {
        public ulong Id { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskId { get; set; }
        public string? TagId { get; set; }
        public string? Name { get; set; }
        public int IsBillable { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string TotalTime { get; set; } = null!;
        public string IsActive { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
