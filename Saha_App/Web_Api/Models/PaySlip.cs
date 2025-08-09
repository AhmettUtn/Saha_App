using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class PaySlip
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public int NetPayble { get; set; }
        public string SalaryMonth { get; set; } = null!;
        public int Status { get; set; }
        public int BasicSalary { get; set; }
        public string Allowance { get; set; } = null!;
        public string Commission { get; set; } = null!;
        public string Loan { get; set; } = null!;
        public string SaturationDeduction { get; set; } = null!;
        public string OtherPayment { get; set; } = null!;
        public string Overtime { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
