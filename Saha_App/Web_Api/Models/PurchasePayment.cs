using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class PurchasePayment
    {
        public ulong Id { get; set; }
        public int PurchaseId { get; set; }
        public DateOnly Date { get; set; }
        public double Amount { get; set; }
        public int AccountId { get; set; }
        public int PaymentMethod { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public string? AddReceipt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
