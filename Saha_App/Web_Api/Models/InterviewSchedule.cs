using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class InterviewSchedule
    {
        public ulong Id { get; set; }
        public int Candidate { get; set; }
        public int Employee { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string? Comment { get; set; }
        public string? EmployeeResponse { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
