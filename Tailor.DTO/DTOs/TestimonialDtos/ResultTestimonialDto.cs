using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TestimonialDtos
{
    // RESULT (Ürün sayfasında onaylı yorumları gösterirken)
    public class ResultTestimonialDto
    {
        public int TestimonialId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public string PhotoUrl { get; set; }
        public string AuthorName { get; set; } // Yorumu yapanın adı
        public DateTime CreatedAt { get; set; }
    }
}
