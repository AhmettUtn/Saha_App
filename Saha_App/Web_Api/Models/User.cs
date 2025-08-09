using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class User
    {
        public User()
        {
            ClientDeals = new HashSet<ClientDeal>();
            UserDeals = new HashSet<UserDeal>();
            UserLeads = new HashSet<UserLead>();
        }

        public ulong Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = null!;
        public DateTime? EmailVerifiedAt { get; set; }
        public string? Password { get; set; }
        public int? Plan { get; set; }
        public DateOnly? PlanExpireDate { get; set; }
        public int RequestedPlan { get; set; }
        public string? Type { get; set; }
        public string? Avatar { get; set; }
        public string? Lang { get; set; }
        public string Mode { get; set; } = null!;
        public int CreatedBy { get; set; }
        public int? DefaultPipeline { get; set; }
        public int DeleteStatus { get; set; }
        public int IsActive { get; set; }
        public string? RememberToken { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string MessengerColor { get; set; } = null!;
        public bool DarkMode { get; set; }
        public bool ActiveStatus { get; set; }

        public virtual ICollection<ClientDeal> ClientDeals { get; set; }
        public virtual ICollection<UserDeal> UserDeals { get; set; }
        public virtual ICollection<UserLead> UserLeads { get; set; }
    }
}
