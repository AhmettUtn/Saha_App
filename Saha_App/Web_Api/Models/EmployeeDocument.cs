using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class EmployeeDocument
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public int DocumentId { get; set; }
        public string DocumentValue { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
