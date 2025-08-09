using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class AttendanceEmployee
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public DateOnly Date { get; set; }
        public string Status { get; set; } = null!;
        public TimeOnly ClockIn { get; set; }
        public TimeOnly ClockOut { get; set; }
        public TimeOnly Late { get; set; }
        public TimeOnly EarlyLeaving { get; set; }
        public TimeOnly Overtime { get; set; }
        public TimeOnly TotalRest { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
