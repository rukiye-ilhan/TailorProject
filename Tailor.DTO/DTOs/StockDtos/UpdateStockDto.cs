using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.StockDtos
{
    // UPDATE (Stok güncelleme işlemi için)
    public class UpdateStockDto
    {
        // Hangi ürünün stoğu güncelleniyor?
        public int ProductId { get; set; }

        // Yeni miktar
        public decimal Quantity { get; set; }

        // Raf/Depo konumu değişikliği varsa
        public string Location { get; set; }
    }
}
