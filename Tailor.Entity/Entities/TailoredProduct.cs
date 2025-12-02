using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class TailoredProduct
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsShowcased { get; set; }

        // Foreign Key ve Navigasyon
        public int ProductId { get; set; }
        public Product Product { get; set; }


    }
}
