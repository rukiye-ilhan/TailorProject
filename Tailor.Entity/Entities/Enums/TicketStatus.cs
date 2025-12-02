using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum TicketStatus
    {
        Open,       // Açık
        replied,   // Cevaplandı
        Closed,     // Kapalı
        Reopened,     // Yeniden Açıldı
        Pending     // Beklemede
    }
}
