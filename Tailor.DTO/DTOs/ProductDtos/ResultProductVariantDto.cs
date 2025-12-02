using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ProductDtos
{
    public class ResultProductVariantDto
    {
        public int Id { get; set; } // Varyant ID'si (Sepete eklerken bu ID lazım!)
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal StockQuantity { get; set; }
        public bool IsInStock => StockQuantity > 0;
    }
}
