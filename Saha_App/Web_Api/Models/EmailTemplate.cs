using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class EmailTemplate
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string? From { get; set; }
        public string? Slug { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
