using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class StockReport
    {
        public ulong Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; } = null!;
        public int TypeId { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
