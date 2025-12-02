using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ProductDtos
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; } // Zorunlu
        public string SKU { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }

        // Güncellemede etiket listesini tamamen değiştirmek için
        public List<int> TagIds { get; set; }
    }
}
