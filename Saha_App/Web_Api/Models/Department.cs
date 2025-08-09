using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Department
    {
        public ulong Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
