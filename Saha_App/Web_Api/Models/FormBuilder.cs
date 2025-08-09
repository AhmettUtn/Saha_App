using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class FormBuilder
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int IsActive { get; set; }
        public int IsLeadActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
