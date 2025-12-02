using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TailoredProductDtos
{
    // UPDATE
    public class UpdateTailoredProductDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsShowcased { get; set; }
    }
}
