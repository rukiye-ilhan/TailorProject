using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class ShoppingCart
    {
    
        public int ShoppingCartId { get; set; }
        public string SessionId { get; set; }    //Anonim kullanıcılar için 
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
        //Foreign Key ve Navigasyon Property
        public int UserId { get; set; } //Anonim kullanıcılar için nullable olabilir
        public AppUser User { get; set; }
        //Navigasyon
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}   
