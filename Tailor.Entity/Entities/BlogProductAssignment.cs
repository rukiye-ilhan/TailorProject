using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    //Junction Table
    public class BlogProductAssignment
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int ProductId { get; set; } // Dükkandaki Satılık Ürün
        public Product Product { get; set; }
    }
}
