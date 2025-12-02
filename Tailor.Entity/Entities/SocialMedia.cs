using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class SocialMedia
    {
        // --- EKSİK OLAN KISIM (Birincil Anahtar) ---
        public int SocialMediaId { get; set; }

        public string PlatformName { get; set; } // Örn: Instagram, Facebook
        public string IconUrl { get; set; }      // Örn: FontAwesome class'ı veya resim yolu
        public string ProfileUrl { get; set; }   // Örn: https://instagram.com/terzi
        public bool IsActive { get; set; }
    }
}
