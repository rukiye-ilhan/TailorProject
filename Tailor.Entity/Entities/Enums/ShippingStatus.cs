using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum ShippingStatus
    {
        // Gönderinin henüz işlenmediği, kargo şirketine teslim edilmeyi beklediği durum.
        Pending,

        // Gönderi paketlendi ve kargo şirketine teslim edilmek üzere hazırlandı.
        ReadyForShipping,

        // Gönderi, kargo şirketi tarafından yola çıkarıldı.
        Shipped,

        // Gönderi, teslimat için dağıtım merkezine ulaştı.
        InTransit,

        // Gönderi, alıcıya teslim edilmek üzere yola çıktı.
        OutForDelivery,

        // Gönderi, alıcıya başarıyla teslim edildi.
        Delivered,

        // Teslimat girişimi başarısız oldu (örneğin, alıcı adreste yoktu).
        DeliveryFailed,

        // Gönderi geri dönüyor (örneğin, iade veya yanlış adres nedeniyle).
        Returned,

        // Gönderi, kayıp veya hasarlı olarak bildirildi.
        LostOrDamaged
    }
}
