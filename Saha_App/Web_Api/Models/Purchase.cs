using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Purchase
    {
        public ulong Id { get; set; }
        public string PurchaseId { get; set; } = null!;
        public int VenderId { get; set; }
        public int WarehouseId { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public int PurchaseNumber { get; set; }
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
