using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.CustomerSocialDtos
{
    public class ResultCustomerSocialDto
    {
        // Kaydın benzersiz kimliği
        public int CustomerSocialId { get; set; }

        // Hangi sosyal medya (örneğin: "Instagram")
        public string SocialMediaName { get; set; }

        // Sosyal medya simgesinin adresi veya kodu
        public string IconUrl { get; set; }

        // Profilin URL'si
        public string ProfileUrl { get; set; }

        // Kaydın aktiflik durumu
        public bool IsActive { get; set; }

        // Hangi müşteriye ait olduğu bilgisi
        public int CustomerId { get; set; }

        // Sosyal medya simgesinin doğrudan kodu
        public string Icon { get; set; }
    }
}
