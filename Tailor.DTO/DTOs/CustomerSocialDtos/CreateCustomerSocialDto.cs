using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.CustomerSocialDtos
{
    public class CreateCustomerSocialDto
    {
        // Hangi sosyal medya (örneğin: "Instagram", "Twitter")
        public string SocialMediaName { get; set; }

        // Profilin URL'si (örneğin: "https://twitter.com/kullaniciadi")
        public string ProfileUrl { get; set; }

        // Sosyal medya simgesinin adresi veya kodu
        public string IconUrl { get; set; }

        // Sosyal medya simgesinin doğrudan kodu (örneğin FontAwesome sınıf adı)
        public string Icon { get; set; }

        // Hangi müşteriye ait olduğu bilgisi (zorunluysa)
        public int CustomerId { get; set; }
    }
}
