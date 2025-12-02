using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.SupportTicketDtos
{
    // RESULT (Kullanıcı veya Admin listelerken)
    public class ResultSupportTicketDto
    {
        public int SupportTicketId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
        public TicketStatus Status { get; set; }

        // Cevap detayları
        public string AdminReply { get; set; }

        // İlişki Çözümü: Kim açtı?
        public string UserName { get; set; }
    }
}
