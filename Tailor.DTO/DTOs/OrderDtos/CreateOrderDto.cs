using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.OrderDtos
{
    public class CreateOrderDto
    {
        // Hangi sepetteki ürünlerin siparişe dönüşeceğini belirtir.
        public int ShoppingCartId { get; set; }

        // Adres Seçimleri (Kullanıcının kayıtlı adreslerinden seçtiği ID'ler)
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }

        // Ödeme Yöntemi (Kullanıcının seçimi)
        public PaymentMethod PaymentMethod { get; set; }
    }
}