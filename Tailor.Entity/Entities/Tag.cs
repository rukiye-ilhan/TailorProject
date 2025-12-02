using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        //Navigation property
        public ICollection<ProductTag> ProductTags { get; set; }
    }
}
