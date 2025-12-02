using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Entity.Entities.Enums;

namespace Tailor.DTO.DTOs.SupportTicketDtos
{
    // ANSWER / UPDATE (Admin cevap verirken veya durum değiştirirken)
    public class AnswerSupportTicketDto
    {
        public int SupportTicketId { get; set; }
        public string AdminReply { get; set; }
        public TicketStatus Status { get; set; } // "Replied" veya "Closed" yapılabilir
    }
}
