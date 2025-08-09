using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Contract
    {
        public ulong Id { get; set; }
        public int ClientName { get; set; }
        public string? Subject { get; set; }
        public string? Value { get; set; }
        public int Type { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string? Description { get; set; }
        public string? ProjectId { get; set; }
        public string? ContractDescription { get; set; }
        public string Status { get; set; } = null!;
        public string? ClientSignature { get; set; }
        public string? CompanySignature { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
