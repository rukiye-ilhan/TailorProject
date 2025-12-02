using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public class Shipping
    {
        public int ShippingId { get; set; }
        //üpublic string Carrier { get; set; }
        public Decimal ShippingCost { get; set; }
        public string ShippingCompany { get; set; }
        //public string TrackingNumber { get; set; }
        //public DateTime ShippedDate { get; set; }
        //public DateTime? DeliveryDate { get; set; }
        //public DateTime EstimatedDeliveryDate { get; set; }
        public ShippingStatus Status { get; set; }//enum
        public string ShippingMethod { get; set; }

        //Foreign Key ve Navigasyon Property
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
