using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class BillPayment
    {
        public ulong Id { get; set; }
        public int BillId { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public int PaymentMethod { get; set; }
        public string? Reference { get; set; }
        public string? AddReceipt { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
