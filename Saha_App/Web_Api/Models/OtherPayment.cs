using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class OtherPayment
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public string Title { get; set; } = null!;
        public int Amount { get; set; }
        public string? Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
