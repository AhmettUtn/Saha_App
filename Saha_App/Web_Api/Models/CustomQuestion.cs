using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class CustomQuestion
    {
        public ulong Id { get; set; }
        public string Question { get; set; } = null!;
        public string? IsRequired { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
