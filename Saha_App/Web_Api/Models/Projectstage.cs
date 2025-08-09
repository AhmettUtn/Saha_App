using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Projectstage
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Color { get; set; }
        public int CreatedBy { get; set; }
        public int Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
