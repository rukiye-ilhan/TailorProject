using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TailoredProductDtos
{
    // CREATE (Portfolyoya yeni iş ekleme)
    public class CreateTailoredProductDto
    {
        // Hangi standart ürünün dikilmiş hali?
        public int ProductId { get; set; }

        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsShowcased { get; set; } // Anasayfada gösterilsin mi?
    }
}
