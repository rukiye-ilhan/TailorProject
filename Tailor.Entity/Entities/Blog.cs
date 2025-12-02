using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        /*//Foreign Key ve Navigasyon Property:Bir blog yazısını kategorisine bağlar.
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }*/
        // Navigasyon Özelliği: Birden fazla kategori atamasına referans verir.
        public ICollection<BlogCategoryAssignment> CategoryAssignments { get; set; }

    }
}
