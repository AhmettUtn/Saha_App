using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class LogActivity
    {
        public ulong Id { get; set; }
        public string Type { get; set; } = null!;
        public DateOnly StartDate { get; set; }
        public TimeOnly Time { get; set; }
        public string Note { get; set; } = null!;
        public string ModuleType { get; set; } = null!;
        public ulong ModuleId { get; set; }
        public ulong CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
