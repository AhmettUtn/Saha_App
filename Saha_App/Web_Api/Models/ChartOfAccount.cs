using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ChartOfAccount
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public int Code { get; set; }
        public int Type { get; set; }
        public int SubType { get; set; }
        public int IsEnabled { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
