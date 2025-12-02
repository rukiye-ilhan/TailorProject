using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.StockDtos
{
    // RESULT (Ürün detayında veya Admin stok listesinde göstermek için)
    public class ResultStockDto
    {
        public int StockId { get; set; }
        public decimal Quantity { get; set; }
        public string Location { get; set; }

        // Stok durumunu metin olarak göstermek için (Hesaplanmış alan)
        // Örn: Quantity > 0 ? "Stokta" : "Tükendi"
        public string StockStatus { get; set; }
    }
}
