using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class JournalEntry
    {
        public ulong Id { get; set; }
        public DateOnly Date { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public int JournalId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
