using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Notification
    {
        public ulong Id { get; set; }
        public long UserId { get; set; }
        public string Type { get; set; } = null!;
        public string Data { get; set; } = null!;
        public sbyte IsRead { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
