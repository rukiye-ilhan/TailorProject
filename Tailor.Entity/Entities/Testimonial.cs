using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public string  PhotoUrl { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsApproved { get; set; }
        //Foreign Key ve Navigasyon Property
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
