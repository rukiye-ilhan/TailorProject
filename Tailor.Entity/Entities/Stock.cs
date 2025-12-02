using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Stock
    {
        public int StockId { get; set; }
        public decimal Quantity { get; set; }
        public string Location { get; set; }
        //Foreign Key ve Navigasyon Property
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
