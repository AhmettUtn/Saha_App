using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Loan
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public int LoanOption { get; set; }
        public string Title { get; set; } = null!;
        public int Amount { get; set; }
        public string? Type { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Reason { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
