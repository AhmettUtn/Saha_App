using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Lead
    {
        public Lead()
        {
            LeadCalls = new HashSet<LeadCall>();
            LeadDiscussions = new HashSet<LeadDiscussion>();
            LeadEmails = new HashSet<LeadEmail>();
            LeadFiles = new HashSet<LeadFile>();
            UserLeads = new HashSet<UserLead>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Subject { get; set; } = null!;
        public int UserId { get; set; }
        public int PipelineId { get; set; }
        public int StageId { get; set; }
        public string? Sources { get; set; }
        public string? Products { get; set; }
        public string? Notes { get; set; }
        public string? Labels { get; set; }
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
        public int IsConverted { get; set; }
        public DateOnly? Date { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<LeadCall> LeadCalls { get; set; }
        public virtual ICollection<LeadDiscussion> LeadDiscussions { get; set; }
        public virtual ICollection<LeadEmail> LeadEmails { get; set; }
        public virtual ICollection<LeadFile> LeadFiles { get; set; }
        public virtual ICollection<UserLead> UserLeads { get; set; }
    }
}
