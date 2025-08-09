using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Goal
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? From { get; set; }
        public string? To { get; set; }
        public double Amount { get; set; }
        public int IsDisplay { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
