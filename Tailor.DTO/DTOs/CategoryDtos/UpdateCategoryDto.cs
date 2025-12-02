using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.CategoryDtos
{
    public class UpdateCategoryDto
    {
        // Zorunlu Kimlik
        public int CategoryId { get; set; }

        // Güncellenecek Alanlar
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Hiyerarşi Değişikliği: Kategoriyi başka bir ana kategoriye taşımak için kullanılır.
        public int? ParentCategoryId { get; set; }
    }
}
