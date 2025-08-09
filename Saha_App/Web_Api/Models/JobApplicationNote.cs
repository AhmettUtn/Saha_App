using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class JobApplicationNote
    {
        public ulong Id { get; set; }
        public int ApplicationId { get; set; }
        public int NoteCreated { get; set; }
        public string? Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
