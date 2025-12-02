using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }//enum siprişin durumunu kolayca yönetme imkanı veren enum yapısıdır.
        public Decimal TotalAmount { get; set; }
        //Foreign Key ve Navigasyon Property
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        //Navigasyon
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Payment> Payments { get; set; }
        // Kargo politikası ile bire-bir ilişki
        public Shipping Shipping { get; set; }
        public ICollection<Shipment> Shipments { get; set; }//bu bir siparişin birden  fazla gönderim nesnesine erişimini sağlar



    }
}
