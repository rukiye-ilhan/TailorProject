using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ProductDtos
{
    public class ResultProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } // Ana resim (Genellikle ilk display resmi)
        public bool IsActive { get; set; }
    }
}
