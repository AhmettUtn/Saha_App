using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Timesheet
    {
        public ulong Id { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
