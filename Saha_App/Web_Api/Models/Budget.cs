using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Budget
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Period { get; set; } = null!;
        public string? From { get; set; }
        public string? To { get; set; }
        public string? IncomeData { get; set; }
        public string? ExpenseData { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
