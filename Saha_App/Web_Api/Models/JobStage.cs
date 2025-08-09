using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class JobStage
    {
        public ulong Id { get; set; }
        public string Title { get; set; } = null!;
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
