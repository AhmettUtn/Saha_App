using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class JobOnBoard
    {
        public ulong Id { get; set; }
        public int Application { get; set; }
        public DateOnly? JoiningDate { get; set; }
        public string? Status { get; set; }
        public int ConvertToEmployee { get; set; }
        public string? SalaryDuration { get; set; }
        public string? SalaryType { get; set; }
        public int? Salary { get; set; }
        public int? DaysOfWeek { get; set; }
        public string? JobType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
