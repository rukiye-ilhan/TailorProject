using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Address
    {
        public int id { get; set; }
        public string AddressLine1 { get; set; }
        public string  City { get; set; }
        public string  State { get; set; }
        public string  ZipCode { get; set; }
        public string Country { get; set; }
        public bool  IsDefault { get; set; }

        //foreign key ve navigasyo property
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}
