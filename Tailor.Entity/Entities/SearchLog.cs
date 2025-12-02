using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class SearchLog
    {
        public int SearchLogId { get; set; }
        public string SearchQuery { get; set; } // Kullanıcının arama çubuğuna yazdığı terim
        public DateTime SearchDate { get; set; }
        public int ResultCount { get; set; } // Arama sonucunda bulunan öğe sayısı

        // Arama yapan kullanıcıyı takip etmek için Foreign Key ve Navigasyon özelliği
        // Anonim kullanıcılar da arama yapabileceği için UserId nullable olabilir.
        public int? UserId { get; set; }
        public AppUser User { set; get; }
    }
}
