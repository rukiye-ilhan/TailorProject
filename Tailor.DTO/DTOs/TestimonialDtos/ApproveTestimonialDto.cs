using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.TestimonialDtos
{
    // APPROVE / UPDATE (Admin yorumu onaylarken)
    public class ApproveTestimonialDto
    {
        public int TestimonialId { get; set; }
        public bool IsApproved { get; set; }
    }
}
