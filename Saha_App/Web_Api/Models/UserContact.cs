using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class UserContact
    {
        public ulong Id { get; set; }
        public int ParentId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
