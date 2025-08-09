using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class InvoicePayment
    {
        public ulong Id { get; set; }
        public int InvoiceId { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public int PaymentMethod { get; set; }
        public string? Receipt { get; set; }
        public string PaymentType { get; set; } = null!;
        public string? TxnId { get; set; }
        public string? Currency { get; set; }
        public string? OrderId { get; set; }
        public string? Reference { get; set; }
        public string? AddReceipt { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
