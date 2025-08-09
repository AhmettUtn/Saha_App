using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ChartOfAccountSubType
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public int Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
