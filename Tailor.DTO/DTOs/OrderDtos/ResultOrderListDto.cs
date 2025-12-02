using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.OrderDtos
{
    public class ResultOrderListDto
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; } // "Hazırlanıyor", "Kargoda" vb.
        public decimal TotalAmount { get; set; } // Listede fiyatı görmek önemlidir

        // İlişki Çözümü: Siparişin kime ait olduğunu tek bir string ile gösteririz.
        public string CustomerName { get; set; }

        // Siparişte kaç parça ürün olduğunu göstermek (Detaya girmeden bilgi verir)
        public int TotalItemCount { get; set; }
    }
}
