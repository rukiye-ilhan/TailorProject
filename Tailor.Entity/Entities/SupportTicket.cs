using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Entity.Entities
{
    public class SupportTicket
    {
      
        public int SupportTicketId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }// Nullable Talep kapatıldığında
        public TicketStatus Status { get; set; } // Örneğin: Açık, Kapalı, Beklemede
        public int UserId { get; set; } // Destek talebini oluşturan kullanıcı AppUser'dan gelen string tipindeki ıd
        // Navigasyon özelliği
        public AppUser User { get; set; } // Navigasyon özelliği

        //Admin yanıtları için bir koleksiyon
        public string? AdminReply { get; set; }//nullable yönetici cevabını saklar
        public int? AdminId { get; set; }//nullable hangi yöneticinin cevapladığını belirtir.
        //Navigasyon özelliği
        public AppUser Admin { get; set; } // Navigasyon özelliği


    }
}
