using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class About
    {
        // EKSİK OLAN KISIM BURASIYDI:
        public int AboutId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
