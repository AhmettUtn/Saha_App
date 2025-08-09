using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class TaskStage
    {
        public ulong Id { get; set; }
        public string? Name { get; set; }
        public bool Complete { get; set; }
        public ulong ProjectId { get; set; }
        public string? Color { get; set; }
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
