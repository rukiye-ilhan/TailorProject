using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.ShipmentDtos
{
    public class CreateShipmentDto
    {
        // Hangi siparişin gönderildiği
        public int OrderId { get; set; }

        // Taşıyıcı Bilgileri
        public string Carrier { get; set; }       // Örn: Yurtiçi Kargo
        public string TrackingNumber { get; set; } // Örn: 123456789

        // Admin gönderim tarihini manuel girebilir veya sistem o anı alır
        public DateTime ShippedDate { get; set; }

        // Varsayılan durumu "Shipped" olarak ayarlamak için enum gönderilebilir
        public ShipmentStatus Status { get; set; }
    }
}
