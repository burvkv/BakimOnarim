using bakimonarim.core.DataAccess.EntityFramework;
using bakimonarim.dataaccess.Abstract;
using bakimonarim.entity;

namespace bakimonarim.dataaccess.Concrete
{
    public class VGrupDal : EfEntityRepositoryBase<VGrup, BakimOnarimDbContext>, IVGrupDal
    {

    }
}
