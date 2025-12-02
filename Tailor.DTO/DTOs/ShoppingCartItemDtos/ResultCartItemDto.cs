using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ShoppingCartItem
{
    // RESULT (Sepetteki satırı gösterme)
    public class ResultCartItemDto
    {
        public int ShoppingCartItemId { get; set; }
        public int ProductId { get; set; }

        // Ürün detaylarını (Flattening) buraya getiriyoruz
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }            // Birim Fiyat
        public decimal TotalPrice => Price * Quantity; // Satır Toplamı (Hesaplanmış)
    }
}
