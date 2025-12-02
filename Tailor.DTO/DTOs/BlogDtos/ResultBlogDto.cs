using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DTO.DTOs.BlogCategoryDtos;

namespace Tailor.DTO.DTOs.BlogDtos
{
    public class ResultBlogDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }

        // Kategori isimlerini ve ID'lerini göstermek için özel bir liste eklenir.
        // Bu, Entity'den çekilen verinin dönüştürülmüş halidir.
        public List<ResultBlogCategoryDto> Categories { get; set; }


        /*Bu categories koleksiyonu, bir blog yazısının ait olduğu her bir kategoriye dair kimlik (Id) ve isim (Name) bilgisini içeren,
         * iç içe geçmiş küçük DTO'lardan oluşan bir listedir. Amacı, bir Entity'nin tüm ilişkili verisini tek bir API çağrısı ile,
         * temiz ve kullanılabilir bir formatta sunmaktır.
         * {
  // ResultBlogDto'nun Temel Alanları
  "blogId": 45,
  "title": "Yazlık Kumaşların Bakımı ve Ütü İpuçları",
  "author": "Yönetici",
  "publishDate": "2025-11-15T10:00:00Z",
  "imageUrl": "/images/kumas/yazlik.jpg",
  
  // Blog içeriğinin tamamı (Performans için ListDto'ya konulmayandı)
  "content": "Gömlek ve elbise yapımında kullanılan ince yazlık kumaşlar, doğru yıkama ve ütü teknikleriyle uzun ömürlü olur. Pamuk ve keten bakımı kritiktir...",

  // Kategori İlişkisinin Yönetildiği Alan (ResultBlogDto'nun parçası)
  "categories": [
    // --- BURASI ResultBlogCategoryDto'dur ---
    { 
      "blogCategoryId": 1, 
      "name": "Kumaş Bakım Rehberi" 
    },
    // --- BURASI ResultBlogCategoryDto'dur ---
    { 
      "blogCategoryId": 8, 
      "name": "Terzi İpuçları" 
    }
    // Bu yapı, blog yazısının birden fazla kategoriye ait olduğunu gösterir.
  ]
}
         * 
         */
    }
}
