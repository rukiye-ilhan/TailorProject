using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public decimal Quantity { get; set; }
        public Decimal Price { get; set; }
        //Foreign Key ve Navigasyon Property
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
