using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class PosProduct
    {
        public ulong Id { get; set; }
        public int PosId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Tax { get; set; } = null!;
        public double Discount { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
