using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DTO.DTOs.CustomerSocialDtos
{
    public class UpdateCustomerSocialDto
    {
        public int CustomerSocialId { get; set; }
        public string SocialMediaName { get; set; }
        public string IconUrl { get; set; }
        public string ProfileUrl { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public string Icon { get; set; }
    }
}
