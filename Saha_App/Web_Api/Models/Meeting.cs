using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Meeting
    {
        public ulong Id { get; set; }
        public int BranchId { get; set; }
        public string DepartmentId { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string? Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
