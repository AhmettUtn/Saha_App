using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ActivityLog
    {
        public ulong Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public int DealId { get; set; }
        public string LogType { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
