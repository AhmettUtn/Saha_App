using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class JobApplication
    {
        public ulong Id { get; set; }
        public int Job { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Profile { get; set; }
        public string? Resume { get; set; }
        public string? CoverLetter { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public int Stage { get; set; }
        public int Order { get; set; }
        public string? Skill { get; set; }
        public int Rating { get; set; }
        public int IsArchive { get; set; }
        public string? CustomQuestion { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
