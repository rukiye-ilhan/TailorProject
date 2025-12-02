using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ProductPropertyDtos
{
    public class CreateProductPropertyDto
    {
        // Hangi ürüne ait olduğu bilgisi (ProductId) burada YOKTUR.
        // Çünkü bu DTO, CreateProductDto'nun içinde liste olarak gidecek.
        public string PropertyName { get; set; }  // Örn: "Renk"
        public string PropertyValue { get; set; } // Örn: "Mavi"
        public string PropertyUnit { get; set; }  // Örn: "RGB" veya boş
    }
}
