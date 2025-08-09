using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Holiday
    {
        public ulong Id { get; set; }
        public DateOnly Date { get; set; }
        public DateOnly EndDate { get; set; }
        public string Occasion { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
