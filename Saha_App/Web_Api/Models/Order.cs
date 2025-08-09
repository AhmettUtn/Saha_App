using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Order
    {
        public ulong Id { get; set; }
        public string OrderId { get; set; } = null!;
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CardNumber { get; set; }
        public string? CardExpMonth { get; set; }
        public string? CardExpYear { get; set; }
        public string? PlanName { get; set; }
        public int PlanId { get; set; }
        public double Price { get; set; }
        public string? PriceCurrency { get; set; }
        public string? TxnId { get; set; }
        public string? PaymentStatus { get; set; }
        public string PaymentType { get; set; } = null!;
        public string? Receipt { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
