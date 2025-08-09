using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class BugComment
    {
        public ulong Id { get; set; }
        public string Comment { get; set; } = null!;
        public int BugId { get; set; }
        public string UserType { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
