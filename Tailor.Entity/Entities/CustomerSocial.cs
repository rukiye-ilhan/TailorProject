using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class CustomerSocial
    {
        // --- EKSİK OLAN KISIM (Birincil Anahtar) ---
        public int CustomerSocialId { get; set; }
        public string SocialMediaName { get; set; } // Örn: Instagram, Facebook
        public string IconUrl { get; set; }      // Örn: FontAwesome class'ı veya resim yolu
        public string ProfileUrl { get; set; }   // Örn: https://instagram.com/terzi
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public string Icon { get; set; }
        public virtual AppUser Customer { get; set; }


    }
}
