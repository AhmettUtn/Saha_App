using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class ProductService
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public string? TaxId { get; set; }
        public int CategoryId { get; set; }
        public int UnitId { get; set; }
        public string Type { get; set; } = null!;
        public string? Description { get; set; }
        public string? ProImage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? OlmasiGerekenStok { get; set; }
    }
}
