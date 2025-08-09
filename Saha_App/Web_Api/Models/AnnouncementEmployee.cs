using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class AnnouncementEmployee
    {
        public ulong Id { get; set; }
        public int AnnouncementId { get; set; }
        public int EmployeeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
