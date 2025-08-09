using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Employee
    {
        public ulong Id { get; set; }
        public int UserId { get; set; }
        public string? Name { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string EmployeeId { get; set; } = null!;
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public string? CompanyDoj { get; set; }
        public string? Documents { get; set; }
        public string? AccountHolderName { get; set; }
        public string? AccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? BankIdentifierCode { get; set; }
        public string? BranchLocation { get; set; }
        public string? TaxPayerId { get; set; }
        public int? SalaryType { get; set; }
        public int? Salary { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
