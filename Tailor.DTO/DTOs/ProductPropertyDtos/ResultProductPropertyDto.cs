using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ProductPropertyDtos
{
    // RESULT (Ürün detayında göstermek için)
    public class ResultProductPropertyDto
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public string PropertyUnit { get; set; }
    }
}
