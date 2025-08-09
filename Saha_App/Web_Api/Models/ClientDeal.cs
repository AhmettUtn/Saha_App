using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ClientDeal
    {
        public ulong Id { get; set; }
        public ulong ClientId { get; set; }
        public ulong DealId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User Client { get; set; } = null!;
        public virtual Deal Deal { get; set; } = null!;
    }
}
