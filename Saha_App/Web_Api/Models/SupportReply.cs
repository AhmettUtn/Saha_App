using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class SupportReply
    {
        public ulong Id { get; set; }
        public int SupportId { get; set; }
        public int User { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public int IsRead { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
