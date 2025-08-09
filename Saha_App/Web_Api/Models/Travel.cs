using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Travel
    {
        public ulong Id { get; set; }
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string? PurposeOfVisit { get; set; }
        public string? PlaceOfVisit { get; set; }
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
