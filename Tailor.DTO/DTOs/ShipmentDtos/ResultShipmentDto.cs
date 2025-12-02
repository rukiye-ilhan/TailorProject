using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.ShipmentDtos
{// RESULT (Sipariş detayında kargo takibi göstermek için)
    public class ResultShipmentDto
    {
        public int ShipmentId { get; set; }
        public string Carrier { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public ShipmentStatus Status { get; set; }
    }
}
