using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Vender
    {
        public ulong Id { get; set; }
        public int VenderId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? TaxNumber { get; set; }
        public string? Password { get; set; }
        public string? Contact { get; set; }
        public string Avatar { get; set; } = null!;
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string? BillingName { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingState { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingPhone { get; set; }
        public string? BillingZip { get; set; }
        public string? BillingAddress { get; set; }
        public string? ShippingName { get; set; }
        public string? ShippingCountry { get; set; }
        public string? ShippingState { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingPhone { get; set; }
        public string? ShippingZip { get; set; }
        public string? ShippingAddress { get; set; }
        public string Lang { get; set; } = null!;
        public double Balance { get; set; }
        public string? RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
