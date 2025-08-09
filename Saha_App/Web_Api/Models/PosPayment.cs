using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class PosPayment
    {
        public ulong Id { get; set; }
        public int PosId { get; set; }
        public DateOnly? Date { get; set; }
        public string Amount { get; set; } = null!;
        public double? DiscountAmount { get; set; }
        public double? Discount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
