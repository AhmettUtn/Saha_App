using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Transaction
    {
        public ulong Id { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; } = null!;
        public int Account { get; set; }
        public string? Type { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public DateOnly Date { get; set; }
        public int CreatedBy { get; set; }
        public int PaymentId { get; set; }
        public string Category { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
