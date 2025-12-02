using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.PaymentDtos
{
    public class ResultPaymentDto
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string TransactionId { get; set; } // Bankadan dönen işlem kodu
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
