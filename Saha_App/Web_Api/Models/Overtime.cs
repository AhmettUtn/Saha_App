using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Overtime
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public string Title { get; set; } = null!;
        public int NumberOfDays { get; set; }
        public int Hours { get; set; }
        public int Rate { get; set; }
        public string? Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
