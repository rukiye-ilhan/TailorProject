using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum DisplayType
    {
        //En yaygın e-ticaret vitrin ürünleri customer taleplerine göre admin tarafında eklentilerle yönetilecektir
        Bestseller,      // Çok Satanlar
        Campaign,        // Kampanya Ürünleri
        NewArrival,      // Yeni Gelenler
        Featured,        // Öne Çıkanlar (Editörün Seçimi)
        OnSale           // İndirimli Ürünler
    }
}
