using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class CustomField
    {
        public CustomField()
        {
            CustomFieldValues = new HashSet<CustomFieldValue>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Module { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<CustomFieldValue> CustomFieldValues { get; set; }
    }
}
