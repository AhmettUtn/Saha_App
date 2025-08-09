using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Deal
    {
        public Deal()
        {
            ClientDeals = new HashSet<ClientDeal>();
            DealCalls = new HashSet<DealCall>();
            DealDiscussions = new HashSet<DealDiscussion>();
            DealEmails = new HashSet<DealEmail>();
            DealFiles = new HashSet<DealFile>();
            DealTasks = new HashSet<DealTask>();
            UserDeals = new HashSet<UserDeal>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Phone { get; set; }
        public double? Price { get; set; }
        public int PipelineId { get; set; }
        public int StageId { get; set; }
        public string? Sources { get; set; }
        public string? Products { get; set; }
        public string? Notes { get; set; }
        public string? Labels { get; set; }
        public string? Status { get; set; }
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<ClientDeal> ClientDeals { get; set; }
        public virtual ICollection<DealCall> DealCalls { get; set; }
        public virtual ICollection<DealDiscussion> DealDiscussions { get; set; }
        public virtual ICollection<DealEmail> DealEmails { get; set; }
        public virtual ICollection<DealFile> DealFiles { get; set; }
        public virtual ICollection<DealTask> DealTasks { get; set; }
        public virtual ICollection<UserDeal> UserDeals { get; set; }
    }
}
