using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Coupon
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public double Discount { get; set; }
        public int Limit { get; set; }
        public string? Description { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
