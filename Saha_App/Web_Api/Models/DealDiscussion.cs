using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class DealDiscussion
    {
        public ulong Id { get; set; }
        public ulong DealId { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Deal Deal { get; set; } = null!;
    }
}
