using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Navigasyon Özelliği (Birçok-Bir ilişki için)
        /*public ICollection<Blog> Blogs { get; set; } // Bir kategori birden fazla bloga sahip olabilir*/
        // Navigasyon Özelliği: Birden fazla blog atamasına referans verir.
        public ICollection<BlogCategoryAssignment> CategoryAssignments { get; set; }

    }
}
