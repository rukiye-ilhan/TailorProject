using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DTO.DTOs.ProductPropertyDtos;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } // Uzun açıklama burada gelir
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        // Kategori Bilgisi
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // İlişkili Veriler (Nested DTOs)
        public List<ResultProductPropertyDto> Properties { get; set; } // Renk, Beden vb.
        public List<string> Tags { get; set; } // Etiket isimleri ("Yazlık", "Pamuklu")
        public int StockQuantity { get; set; } // Stoktan çekilen miktar
        public ProductType ProductType { get; set; }
        public List<ResultProductVariantDto> Variants { get; set; }
    }
}
