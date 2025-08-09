using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class WarehouseProduct
    {
        public ulong Id { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
