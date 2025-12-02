using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ProductDtos
{
    public class CreateProductVariantDto
    {
        public string Size { get; set; }       // "M"
        public string Color { get; set; }      // "Mavi"
        public decimal StockQuantity { get; set; } // 10
    }
}
