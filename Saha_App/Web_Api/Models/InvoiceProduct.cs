using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class InvoiceProduct
    {
        public ulong Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string? Tax { get; set; }
        public double Discount { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
