using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Competency
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
