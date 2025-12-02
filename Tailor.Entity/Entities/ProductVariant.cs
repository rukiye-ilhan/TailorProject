using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class ProductVariant
    {
        public int Id { get; set; }

        // Hangi ürüne ait? (Örn: "Çiçekli Yazlık Elbise")
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Varyant Özellikleri
        public string Size { get; set; }  // Örn: "S", "M", "38", "40"
        public string Color { get; set; } // Örn: "Kırmızı", "Mavi" (Opsiyonel)

        // Bu bedenden elimizde kaç tane var?
        // Kıyafet adet ile satıldığı için int olabilir, ama sistem genelinde decimal kullandığımız için decimal kalabilir.
        public decimal StockQuantity { get; set; }
    }
}
