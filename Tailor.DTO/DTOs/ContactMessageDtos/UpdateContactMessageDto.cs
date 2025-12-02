using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ContactMessageDtos
{
    public class UpdateContactMessageDto
    {
        // Zorunlu Kimlik: Hangi mesajın güncelleneceğini belirtir.
        public int Id { get; set; }

        // Yönetici Tarafından Yapılan Güncellemeler
        public bool IsRead { get; set; }       // Okundu olarak işaretle
        public bool IsReplied { get; set; }   // Cevaplandı olarak işaretle
        public string ReplyMessage { get; set; } // Yönetici cevabı
    }
}
