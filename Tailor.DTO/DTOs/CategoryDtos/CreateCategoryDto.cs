using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.CategoryDtos
{
    public class CreateCategoryDto
    {
        // Temel Bilgiler
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Hiyerarşi Kurulumu (Foreign Key)
        // Yeni kategorinin hangi ana kategoriye bağlanacağını belirtir. Nullable'dır.
        public int? ParentCategoryId { get; set; }
    }
}
