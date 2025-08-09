using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class PlanRequest
    {
        public ulong Id { get; set; }
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public string Duration { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
