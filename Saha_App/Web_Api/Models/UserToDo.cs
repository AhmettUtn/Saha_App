using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class UserToDo
    {
        public ulong Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsComplete { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
