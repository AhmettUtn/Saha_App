using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class FormResponse
    {
        public ulong Id { get; set; }
        public ulong FormId { get; set; }
        public string? Response { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
