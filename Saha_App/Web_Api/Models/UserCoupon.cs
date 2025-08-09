using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class UserCoupon
    {
        public ulong Id { get; set; }
        public int User { get; set; }
        public int Coupon { get; set; }
        public string? Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
