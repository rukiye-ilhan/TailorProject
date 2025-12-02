using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.BlogDtos
{
    public class ResultBlogListDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }

        // İçeriğin sadece kısa bir önizlemesi (özet)
        public string ShortSummary { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }

        // Listede sadece kategori isimlerini göstermek için basit bir liste yeterli olabilir.
        public List<string> CategoryNames { get; set; }
    }
}
