using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class UserEmailTemplate
    {
        public ulong Id { get; set; }
        public int TemplateId { get; set; }
        public int UserId { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
