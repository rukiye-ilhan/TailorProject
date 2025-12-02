using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.CategoryDtos
{
    public class ResultCategoryDto
    {
        // Temel Bilgiler
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Hiyerarşi Çözümü: Üst Kategorinin Adı
        // ParentCategory navigasyon özelliğinden sadece isim çekilir.
        public string ParentCategoryName { get; set; }

        // İlişki Çözümü: Sayısal Veriler
        // ChildCategories koleksiyonunun kaç elemanı olduğu
        public int ChildCategoryCount { get; set; }
        // Prodacts koleksiyonunun kaç elemanı olduğu
        public int ProductCount { get; set; }

        // Hiyerarşi Gösterimi (Opsiyonel, Ağaç yapısını kurmak için ID'ler)
        public int? ParentCategoryId { get; set; }
    }
}
