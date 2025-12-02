using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ShoppingCartItem
{
    // CREATE / ADD (Sepete Ekleme)
    public class AddCartItemDto
    {
        // Hangi ürün?
        public int ProductId { get; set; }

        // Kaç tane?
        public decimal Quantity { get; set; }

        // DİKKAT: Price (Fiyat) buraya konulmaz! 
        // Fiyat veritabanından (Product tablosundan) okunmalıdır. 
        // Kullanıcının fiyatı manipüle etmesi engellenir.
    }
}
