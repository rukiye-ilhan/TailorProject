using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TagDtos
{
    // RESULT (Ürün detayında veya filtrelerde göstermek için)
    public class ResultTagDto
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
    }
}
