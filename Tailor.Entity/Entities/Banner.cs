using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Banner
    {
        // --- EKSİK OLAN KISIM ---
        public int BannerId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }

        // Opsiyonel: Banner'a tıklayınca gidilecek yer
        public string? LinkUrl { get; set; }
    }
}
