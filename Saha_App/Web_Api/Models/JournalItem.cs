using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class JournalItem
    {
        public ulong Id { get; set; }
        public int Journal { get; set; }
        public int Account { get; set; }
        public string? Description { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
