using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Award
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public string? AwardType { get; set; }
        public DateOnly Date { get; set; }
        public string? Gift { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
