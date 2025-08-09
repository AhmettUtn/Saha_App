using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ChartOfAccountType
    {
        public ulong Id { get; set; }
        public string? Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
