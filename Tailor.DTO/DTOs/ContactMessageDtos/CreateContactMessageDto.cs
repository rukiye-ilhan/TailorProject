using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ContactMessageDtos
{
    public class CreateContactMessageDto
    {
        // [Required] gibi doğrulama kuralları burada yer almalıdır.
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }

        // NOT: UserId, IsRead, Id, ReceivedAt gibi alanlar kullanıcıdan alınmaz.
    }
}
