using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public class ProductDisplay
    {
        //productDisplay sınıfını kullanrak bir ürünü birden fazla vitirinde sergileyebiliriz.
        public int ProductDisplayId { get; set; }
        public string ImageUrl { get; set; }
        public DisplayType DisplayType { get; set; }//enum
        public int DisplayOrder { get; set; }
        //Foreign Key ve Navigasyon Property
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
