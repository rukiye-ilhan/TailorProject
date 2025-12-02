using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public  class Shipment
    {
        public int ShipmentId { get; set; }

        //kargo Şirleti vee takip bilgileri
        public string  Carrier { get; set; }
        public string TrackingNumber { get; set; }
        //Kargo takibi için tarih bilgileri
        public DateTime ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        //public DateTime EstimatedDeliveryDate { get; set; }

        //Kargo gönderim durumu
        public ShipmentStatus Status { get; set; }

        // Foreign Key ve Navigasyon Özelliği (Bire-çok ilişki için)
        // Bir gönderim her zaman bir siparişe aittir
        //Burda herzaman bir sipariş bir gönderimle ilişkilendirilebilir ancak bir sipariş içinde birden fazla ürün varsa ve stokda olma durumuna göre aynı anda 
        //gönderilmeyecekse birden fazla A be B şeklinde gönerimle ilişkilendirilebilir.bu durumda bire çok iliki olmasına sebep olur.

        public int OrderId { get; set; }//bu foreign key ile Order tablosundaki OrderId ile ilişkilendirilir.bu OrderId alanı her bir shipmentın tek bir siparişe bağlı olduğunu garanti eder.
        public Order Order { get; set; }//bir gönderim ait olduğu sıparişin detaylarına erişim sağlar

    }
}
