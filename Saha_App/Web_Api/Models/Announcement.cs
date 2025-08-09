using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Announcement
    {
        public ulong Id { get; set; }
        public string? Title { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int BranchId { get; set; }
        public string DepartmentId { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
