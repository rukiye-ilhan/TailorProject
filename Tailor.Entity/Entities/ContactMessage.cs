using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class ContactMessage
    {
        public int Id { get; set; }
        // GÖNDEREN BİLGİSİ
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }

        // MESAJ İÇERİĞİ
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public DateTime ReceivedAt { get; set; }

        // YÖNETİM DURUMU (Yöneticinin basit takibi için)
        public bool IsRead { get; set; }
        public bool IsReplied { get; set; }

        // İLİŞKİ
        public int? UserId { get; set; } // Nullable: Üye olmayan da gönderebilir
        public AppUser User { get; set; }
    }
}
