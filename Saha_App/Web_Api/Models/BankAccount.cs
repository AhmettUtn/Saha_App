using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class BankAccount
    {
        public ulong Id { get; set; }
        public string HolderName { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public double OpeningBalance { get; set; }
        public string ContactNumber { get; set; } = null!;
        public string BankAddress { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
