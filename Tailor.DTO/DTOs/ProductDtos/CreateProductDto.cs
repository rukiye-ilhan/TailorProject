using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DTO.DTOs.ProductPropertyDtos;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.ProductDtos
{
    public class CreateProductDto
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        // Ürünün kategorisi (Entity kodunda eksik olsa da mutlaka olmalı)
        public int CategoryId { get; set; }

        // İLİŞKİ YÖNETİMİ 1: Etiketler (Çoka-Çok)
        // Kullanıcı sadece etiketlerin ID'lerini gönderir. [1, 5, 8] gibi.
        // ProductTag tablosuyla doğrudan uğraşmaz.
        public List<int> TagIds { get; set; }

        // İLİŞKİ YÖNETİMİ 2: Özellikler (Bire-Çok)
        // Ürünle birlikte özellikleri de aynı anda kaydetmek için.
        public List<CreateProductPropertyDto> Properties { get; set; }

        public ProductType ProductType { get; set; } // Kumaş mı Kıyafet mi?

        // Eğer kıyafet ise bu listeyi dolduracaklar. Kumaş ise boş geçecekler.
        public List<CreateProductVariantDto> Variants { get; set; }
    }
}
