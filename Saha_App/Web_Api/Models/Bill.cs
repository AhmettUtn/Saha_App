using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Bill
    {
        public ulong Id { get; set; }
        public string BillId { get; set; } = null!;
        public int VenderId { get; set; }
        public DateOnly BillDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int OrderNumber { get; set; }
        public int Status { get; set; }
        public int ShippingDisplay { get; set; }
        public DateOnly? SendDate { get; set; }
        public int DiscountApply { get; set; }
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
