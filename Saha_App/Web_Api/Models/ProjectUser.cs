using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ProjectUser
    {
        public ulong Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public int InvitedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
