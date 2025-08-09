using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class CustomFieldValue
    {
        public ulong Id { get; set; }
        public ulong RecordId { get; set; }
        public ulong FieldId { get; set; }
        public string? Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual CustomField Field { get; set; } = null!;
    }
}
