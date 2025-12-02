using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DTO.DTOs.AddressDtos;
using Tailor.DTO.DTOs.OrderItemDtos;
using Tailor.DTO.DTOs.PaymentDtos;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.OrderDtos
{
    public class ResultOrderDto
    {
        // --- Temel Sipariş Bilgileri ---
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }

        // --- Müşteri Bilgisi ---
        public int UserId { get; set; }
        public string CustomerName { get; set; }

        // --- Adres Detayları (Nested DTO) ---
        // Address Entity'sini doğrudan kullanmak yerine ResultAddressDto kullanıyoruz.
        public ResultAddressDto ShippingAddress { get; set; }
        public ResultAddressDto BillingAddress { get; set; }

        // --- Sipariş Kalemleri (Ürünler) ---
        public List<ResultOrderItemDto> OrderItems { get; set; }

        // --- Ödeme Detayları ---
        public List<ResultPaymentDto> Payments { get; set; }

        // --- Kargo Bilgisi (Eğer Shipping sınıfı için DTO yaptıysanız) ---
        // public ResultShippingDto Shipping { get; set; }
    }
}
