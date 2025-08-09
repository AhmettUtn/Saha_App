using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Proposal
    {
        public ulong Id { get; set; }
        public ulong ProposalId { get; set; }
        public ulong CustomerId { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly? SendDate { get; set; }
        public int CategoryId { get; set; }
        public int Status { get; set; }
        public int DiscountApply { get; set; }
        public int ConvertedInvoiceId { get; set; }
        public int IsConvert { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
