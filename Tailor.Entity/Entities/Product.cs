using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string SKU { get; set; }
        public string  Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal  price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CretaedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // Gölge olmaktan çıkarıp gerçek bir mülk haline getiriyoruz:
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Foreign ket ve navigasyon propertyleri
        //public ProductProperty property { get; set; } bundan sa çünkü bir ürünün birden fazla özelliği olabilir
        // Tekil değil, Çoğul (List/Collection) olmalı
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public Stock Stock { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }//çoka-çok ilişki
        public ICollection<ProductDisplay> ProductDisplays { get; set; }
        public ICollection<ShoppingCartItem> CartItems { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Testimonial> Testimonials { get; set; }
        //bir kullanıcının bir ürünü ne zaman görüntülediğini takip etmek için
        //Bu yapı sayesinde en çok görüntülenen ürünleri listeleme veya bir kullanıcının daha önce görüntülediği ürünleri önerme giib özelikleri geliştirebiliriz
        public ICollection<ViewHistory> ViewHistories { get; set; }

        // YENİ ALAN: Bu ürün kumaş mı yoksa elbise mi?
        public ProductType ProductType { get; set; }

        // YENİ NAVİGASYON: Eğer kıyafet ise varyantları (Beden/Stok) burada tutulacak.
        public ICollection<ProductVariant> ProductVariants { get; set; }






    }
}
