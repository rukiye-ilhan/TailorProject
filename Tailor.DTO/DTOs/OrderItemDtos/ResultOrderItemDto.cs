using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.OrderItemDtos
{
    public class ResultOrderItemDto
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }

        // Ürün adını buraya "Flattening" (düzleştirme) yaparak getiriyoruz.
        // Frontend'in tekrar Product tablosuna gitmesine gerek kalmaz.
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; } // Ürün görseli (Opsiyonel)

        public decimal Quantity { get; set; }
        public decimal Price { get; set; } // Birim Fiyat
        public decimal TotalPrice => Quantity * Price; // Toplam Satır Tutarı (Hesaplanmış)
    }
}
