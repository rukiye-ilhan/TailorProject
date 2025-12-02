using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ViewHistoryDtos
{
    // CREATE (Kullanıcı bir ürüne tıkladığında arka planda çalışır)
    public class CreateViewHistoryDto
    {
        public int ProductId { get; set; }
        // UserId token'dan alınır.
        // ViewedAt o anki zaman (DateTime.Now) olarak atanır.
    }
}
