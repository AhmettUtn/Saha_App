using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class TaskChecklist
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public int TaskId { get; set; }
        public string UserType { get; set; } = null!;
        public int CreatedBy { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
