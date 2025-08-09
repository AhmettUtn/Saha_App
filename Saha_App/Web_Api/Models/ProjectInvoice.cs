using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ProjectInvoice
    {
        public ulong Id { get; set; }
        public ulong InvoiceId { get; set; }
        public ulong ProjectId { get; set; }
        public ulong ClientId { get; set; }
        public ulong TaxId { get; set; }
        public DateOnly DueDate { get; set; }
        public int CreatedBy { get; set; }
        public short Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
