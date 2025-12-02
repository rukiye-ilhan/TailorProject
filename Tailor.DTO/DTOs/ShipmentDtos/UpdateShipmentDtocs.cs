using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.ShipmentDtos
{
    public class UpdateShipmentDto
    {
        public int ShipmentId { get; set; }

        // Kargo teslim edildiyse bu tarih güncellenir
        public DateTime? DeliveryDate { get; set; }

        // Durum güncellemesi (Örn: Shipped -> Delivered)
        public ShipmentStatus Status { get; set; }
    }
}
