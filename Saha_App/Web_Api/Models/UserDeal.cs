using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class UserDeal
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong DealId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Deal Deal { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
