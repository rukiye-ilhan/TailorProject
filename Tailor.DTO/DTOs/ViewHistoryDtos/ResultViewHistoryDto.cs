using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.ViewHistoryDtos
{
    // RESULT (Admin panelinde "En son kim neye baktı?" analizi için)
    public class ResultViewHistoryDto
    {
        public int ViewHistoryId { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; } // Varsa kullanıcı adı, yoksa "Ziyaretçi"
        public DateTime ViewedAt { get; set; }
    }
}
