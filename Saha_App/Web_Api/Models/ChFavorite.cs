using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ChFavorite
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long FavoriteId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
