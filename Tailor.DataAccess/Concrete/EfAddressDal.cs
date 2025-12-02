using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DataAccess.Context;
using Tailor.DataAccess.Repositories;

namespace Tailor.DataAccess.Concrete
{
    public class EfAddressDal : GenericRepository<Tailor.Entity.Entities.Address>, Tailor.DataAccess.Abstract.IAddressDal
    {
        public EfAddressDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
