using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DataAccess.Context;
using Tailor.DataAccess.Repositories;

namespace Tailor.DataAccess.Concrete
{
    public class EfShipmentDal : GenericRepository<Tailor.Entity.Entities.Shipment>, Tailor.DataAccess.Abstract.IShipmentDal
    {
        public EfShipmentDal(ApplicationDbContext context) : base(context)
        {
        }
    }
    
    
}
