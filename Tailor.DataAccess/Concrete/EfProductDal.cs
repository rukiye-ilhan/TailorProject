using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DataAccess.Context;
using Tailor.DataAccess.Repositories;

namespace Tailor.DataAccess.Concrete
{
    public class EfProductDal : GenericRepository<Tailor.Entity.Entities.Product>, Tailor.DataAccess.Abstract.IProductDal
    {
        public EfProductDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
