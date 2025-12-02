using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum PaymentStatus
    {
        // Ödeme henüz işlenmedi başlatıldı ama henüz onaylanmadı.
        Pending,
        // Ödeme başarıyla alındı.
        Completed,
        // Ödeme reddedildi veya başarısız oldu.
        Failed,
        // Ödeme iade edildi.
        Refunded,
        // Ödeme iptal edildi.
        Canceled,
        // Ödeme işlemi başarıyla tamamlandı
        Succeeded,      
     
    }
}
