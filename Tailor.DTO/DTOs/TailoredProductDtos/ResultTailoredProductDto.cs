using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TailoredProductDtos
{
    // RESULT (Müşteriye "Bunu biz diktik" diye gösterirken)
    public class ResultTailoredProductDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }

        // Hangi ürün olduğunu belirtmek için
        public int ProductId { get; set; }
        public string ProductName { get; set; } // Ürün adı
    }
}
