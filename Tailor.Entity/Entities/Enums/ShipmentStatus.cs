using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum ShipmentStatus
    {
        Pending,        // Gönderim oluşturuldu, işlem bekliyor
        Processing,     // Depoda hazırlanıyor
        Shipped,        // Kargoya verildi
        Delivered,      // Teslim edildi
        Returned,       // İade edildi
        Failed          // Teslimat başarısız
    }
}
