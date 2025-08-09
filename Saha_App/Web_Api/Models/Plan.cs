using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Plan
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string Duration { get; set; } = null!;
        public int MaxUsers { get; set; }
        public int MaxCustomers { get; set; }
        public int MaxVenders { get; set; }
        public int MaxClients { get; set; }
        public int Crm { get; set; }
        public int Hrm { get; set; }
        public int Account { get; set; }
        public int Project { get; set; }
        public int Pos { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
