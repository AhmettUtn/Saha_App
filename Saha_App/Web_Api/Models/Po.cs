using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Po
    {
        public ulong Id { get; set; }
        public ulong PosId { get; set; }
        public ulong CustomerId { get; set; }
        public int WarehouseId { get; set; }
        public DateOnly? PosDate { get; set; }
        public int CategoryId { get; set; }
        public int Status { get; set; }
        public int ShippingDisplay { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
