using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ShoppingCartItem
{
    // UPDATE (Miktar Güncelleme - Sepette arttır/azalt)
    public class UpdateCartItemDto
    {
        public int ShoppingCartItemId { get; set; }
        public decimal Quantity { get; set; }
    }
}
