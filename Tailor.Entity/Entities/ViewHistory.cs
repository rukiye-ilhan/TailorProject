using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class ViewHistory
    {
        public int ViewHistoryId { get; set; }
        //Foreign key ve navigasyon özellikleri(ürün ile ilişki) 
        //bir görüntüleme kaydı her zaman bir ürüne ve bir kullanıcıta ait olmalıdır.
        public int ProductId { get; set; }
        public Product Product { get; set; }
        //Foreign key ve navigasyon özellikleri(kullanıcı ile ilişki)
        public int UserId { get; set; }
        public AppUser User { get; set; } //Kullanıcı sınıfı mevcutsa bu satırı ekleyin
        //Ürünün görüntülendiği tari ve saat bilgisi
        public DateTime ViewedAt { get; set; }
    }
}
