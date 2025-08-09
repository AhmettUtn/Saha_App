﻿using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ModelHasRole
    {
        public ulong RoleId { get; set; }
        public string ModelType { get; set; } = null!;
        public ulong ModelId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
