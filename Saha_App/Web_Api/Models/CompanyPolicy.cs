using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class CompanyPolicy
    {
        public ulong Id { get; set; }
        public int Branch { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Attachment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
