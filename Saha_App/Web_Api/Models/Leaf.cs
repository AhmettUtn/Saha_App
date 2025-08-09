using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Leaf
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateOnly AppliedOn { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string TotalLeaveDays { get; set; } = null!;
        public string LeaveReason { get; set; } = null!;
        public string? Remark { get; set; }
        public string Status { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
