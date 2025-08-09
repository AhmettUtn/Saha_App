using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Revenue
    {
        public ulong Id { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public int PaymentMethod { get; set; }
        public string? Reference { get; set; }
        public string? AddReceipt { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
