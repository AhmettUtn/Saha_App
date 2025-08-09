using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class LandingPageSection
    {
        public ulong Id { get; set; }
        public string SectionName { get; set; } = null!;
        public int SectionOrder { get; set; }
        public string? Content { get; set; }
        public string SectionType { get; set; } = null!;
        public string DefaultContent { get; set; } = null!;
        public string SectionDemoImage { get; set; } = null!;
        public string SectionBladeFileName { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
