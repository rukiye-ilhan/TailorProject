using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities.Enums
{
    public enum ProductType
    {
        Fabric,       // Kumaş (Metre ile satılır, varyantı yoktur)
        ReadyToWear   // Hazır Giyim (Adet ile satılır, Beden/Renk varyantı vardır)
    }
}
