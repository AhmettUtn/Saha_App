using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class SetSalary
    {
        public ulong Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
