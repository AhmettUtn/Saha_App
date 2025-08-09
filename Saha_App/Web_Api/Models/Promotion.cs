using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Promotion
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public int DesignationId { get; set; }
        public string? PromotionTitle { get; set; }
        public DateOnly PromotionDate { get; set; }
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
