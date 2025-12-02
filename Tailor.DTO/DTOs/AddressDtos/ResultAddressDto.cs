using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.AddressDtos
{
    public class ResultAddressDto
    {
        // Veritabanının oluşturduğu Id, dış dünyaya gösterilir.
        public int Id { get; set; }

        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public bool IsDefault { get; set; }

        // Bu adresin hangi kullanıcıya ait olduğunu göstermek için kullanıcı ID'si gerekebilir.
        // Ancak AppUser'ın tüm detayları değil, sadece Id'si yeterlidir.
        public int AppUserId { get; set; }
        /*Örnek Senaryo (Admin Paneli): Bir yönetici, iade veya kargo sorunu için destek taleplerini incelerken bir adres kaydına bakar.
         * Bu adresin hangi müşteriye ait olduğunu belirlemek için AppUserId'ye ihtiyaç duyar. Bu ID sayesinde, yönetici ilgili kullanıcı profilini hızla bulabilir.
         * farklı arealar olur doğrudan kullanıcılar görsün istenilmez istenen admin görüsn admin taraıfndan burayı görünür kılıcaz kullanıcı bu bilgiye 
         * ihtiya. duyma ancak admin ihtiyaç duyar.
         */
    }
}
