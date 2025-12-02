using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ContactMessageDtos
{
    public class ResultContactMessageDto
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public DateTime ReceivedAt { get; set; }

        // Yönetim durumu
        public bool IsRead { get; set; }
        public bool IsReplied { get; set; }
        public string ReplyMessage { get; set; }

        // Mesajı gönderen kişi eğer üye ise ID bilgisi (Profiline gitmek için kullanılabilir)
        public int? UserId { get; set; }
    }
}