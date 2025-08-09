using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class BankTransfer
    {
        public ulong Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public double Amount { get; set; }
        public DateOnly Date { get; set; }
        public int PaymentMethod { get; set; }
        public string? Reference { get; set; }
        public string Description { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
