
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public decimal Quantity { get; set; }
        public Decimal Price { get; set; }
        //public DateTime AddedAt { get; set; }
        //Foreign Key ve Navigasyon Property
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
