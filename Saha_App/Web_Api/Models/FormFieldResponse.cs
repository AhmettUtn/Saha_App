using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class FormFieldResponse
    {
        public ulong Id { get; set; }
        public ulong FormId { get; set; }
        public int SubjectId { get; set; }
        public int NameId { get; set; }
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public int PipelineId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
