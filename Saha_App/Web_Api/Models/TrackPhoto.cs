using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class TrackPhoto
    {
        public ulong Id { get; set; }
        public int TrackId { get; set; }
        public int UserId { get; set; }
        public string? ImgPath { get; set; }
        public DateTime? Time { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
