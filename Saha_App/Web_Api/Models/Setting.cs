using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Setting
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
