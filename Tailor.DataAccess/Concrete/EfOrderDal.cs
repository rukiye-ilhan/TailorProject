using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DataAccess.Context;
using Tailor.DataAccess.Repositories;

namespace Tailor.DataAccess.Concrete
{
    public class EfOrderDal : GenericRepository<Tailor.Entity.Entities.Order>, Tailor.DataAccess.Abstract.IOrderDal
    {
        public EfOrderDal(ApplicationDbContext context) : base(context)
        {
        }
    
    }
}
