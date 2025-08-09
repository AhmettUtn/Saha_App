using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class CreditNote
    {
        public ulong Id { get; set; }
        public int Invoice { get; set; }
        public int Customer { get; set; }
        public double Amount { get; set; }
        public DateOnly Date { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
