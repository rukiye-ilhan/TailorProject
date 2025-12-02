using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public Decimal Amount { get; set; }
        public string TransactionId { get; set; }
        public PaymentMethod Method { get; set; }//enum
        public PaymentStatus Status { get; set; }//enum
        //Foreign Key ve Navigasyon Property
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
