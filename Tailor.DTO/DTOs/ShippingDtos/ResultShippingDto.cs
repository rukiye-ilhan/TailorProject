using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.ShippingDtos
{
    // RESULT (Sipariş özetinde gösterilir)
    public class ResultShippingDto
    {
        public int ShippingId { get; set; }
        public string ShippingMethod { get; set; }   // Örn: "Hızlı Kargo"
        public string ShippingCompany { get; set; }  // Örn: "UPS"
        public decimal ShippingCost { get; set; }    // Örn: 50.00 TL
        public ShippingStatus Status { get; set; }   // Kargonun genel durumu
    }
}
