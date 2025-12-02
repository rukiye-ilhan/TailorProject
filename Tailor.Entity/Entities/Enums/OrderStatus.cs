using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum OrderStatus
    {
        // Siparişin ilk oluşturulduğu durum
        Pending,

        // Ödeme alındıktan sonra siparişin hazırlanma aşaması
        Processing,

        // Sipariş kargoya verildi ve takip numarası oluşturuldu
        Shipped,

        // Sipariş müşteriye başarıyla teslim edildi
        Delivered,

        // Müşteri veya yönetici tarafından iptal edildi
        Cancelled,

        // Siparişte bir sorun çıktı ve müşteriyle iletişime geçilmesi gerekiyor
        OnHold
    }
}
