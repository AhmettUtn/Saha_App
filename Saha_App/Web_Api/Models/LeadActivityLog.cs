using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class LeadActivityLog
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong LeadId { get; set; }
        public string LogType { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
