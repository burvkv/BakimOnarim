using bakimonarim.core.DataAccess.EntityFramework;
using bakimonarim.dataaccess.Abstract;
using bakimonarim.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.dataaccess.Concrete
{
    public class VarlikDal : EfEntityRepositoryBase<Varlik2, BakimOnarimDbContext>, IVarlikDal
    {
    }
}
