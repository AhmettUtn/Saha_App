using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Invoice
    {
        public ulong Id { get; set; }
        public ulong InvoiceId { get; set; }
        public ulong CustomerId { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly? SendDate { get; set; }
        public int CategoryId { get; set; }
        public string? RefNumber { get; set; }
        public int Status { get; set; }
        public int ShippingDisplay { get; set; }
        public int DiscountApply { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
