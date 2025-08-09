using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Asset
    {
        public ulong Id { get; set; }
        public string? EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly PurchaseDate { get; set; }
        public DateOnly SupportedDate { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
