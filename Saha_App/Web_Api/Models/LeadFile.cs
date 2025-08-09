using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class LeadFile
    {
        public ulong Id { get; set; }
        public ulong LeadId { get; set; }
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Lead Lead { get; set; } = null!;
    }
}
