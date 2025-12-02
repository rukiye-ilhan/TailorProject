using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class ProductProperty
    {
        // DÜZELTME: PropertyId yerine ProductPropertyId (SınıfAdı + Id) PropertId olarak yazınca ef bunu pk olarak agılamıyor.
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public string? PropertyName { get; set; }
        public string? PropertyValue { get; set; }
        public string? PropertyUnit { get; set; }
    }
}
