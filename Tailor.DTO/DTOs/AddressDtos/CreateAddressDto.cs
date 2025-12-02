using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.AddressDtos
{
    public class CreateAddressDto
    {
        // [Required] gibi doğrulama kuralları burada yer almalıdır.
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        // Yeni adresin varsayılan adres olarak ayarlanıp ayarlanmayacağını belirtir.
        public bool IsDefault { get; set; }

        // Not: AppUserId ve Id bilgileri burada yer almaz.
        /*UpdateAddressDto'daki Id alanı, hangi adres kaydının güncelleneceğini belirtir.7
         * AppUserId ise arka planda Identity sistemi tarafından belirlenir ve güvenlik için asla kullanıcıdan beklenen bir girdi olmamalıdır.
         */
    }
}
