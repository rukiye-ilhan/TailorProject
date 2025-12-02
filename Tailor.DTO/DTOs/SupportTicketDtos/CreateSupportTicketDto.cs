using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.SupportTicketDtos
{
    // CREATE (Kullanıcı yeni talep oluştururken)
    public class CreateSupportTicketDto
    {
        public string Subject { get; set; }
        public string Message { get; set; }

        // UserId ve CreatedAt arka planda sistemden (Token'dan) alınır, buraya konmaz.
    }
}
