using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ContractAttachment
    {
        public ulong Id { get; set; }
        public int ContractId { get; set; }
        public int UserId { get; set; }
        public string? Files { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
