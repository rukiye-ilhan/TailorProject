using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TestimonialDtos
{
    // CREATE (Kullanıcı yorum yaparken)
    public class CreateTestimonialDto
    {
        public int ProductId { get; set; } // Hangi ürüne yorum yapılıyor?
        public string Content { get; set; }
        public int Rating { get; set; } // 1-5 arası yıldız
        public string PhotoUrl { get; set; } // Opsiyonel: Müşteri fotoğrafı

        // AuthorName ve CreatedAt sistemden/token'dan alınır.
        // IsApproved varsayılan olarak "False" olur.
    }
}
