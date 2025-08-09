using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Support
    {
        public ulong Id { get; set; }
        public string Subject { get; set; } = null!;
        public int TicketCreated { get; set; }
        public int User { get; set; }
        public string Priority { get; set; } = null!;
        public DateOnly EndDate { get; set; }
        public string? TicketCode { get; set; }
        public string Status { get; set; } = null!;
        public string? Attachment { get; set; }
        public int CreatedBy { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
