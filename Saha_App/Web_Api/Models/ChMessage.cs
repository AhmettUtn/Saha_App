using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ChMessage
    {
        public long Id { get; set; }
        public string Type { get; set; } = null!;
        public long FromId { get; set; }
        public long ToId { get; set; }
        public string? Body { get; set; }
        public string? Attachment { get; set; }
        public bool Seen { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
