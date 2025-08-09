using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Estimation
    {
        public ulong Id { get; set; }
        public ulong EstimationId { get; set; }
        public ulong ClientId { get; set; }
        public string Status { get; set; } = null!;
        public DateOnly IssueDate { get; set; }
        public double Discount { get; set; }
        public ulong TaxId { get; set; }
        public string? Terms { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
