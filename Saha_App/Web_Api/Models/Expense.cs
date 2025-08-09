using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Expense
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly? Date { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public string? Attachment { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
