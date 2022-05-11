using bakimonarim.core.DataAccess.EntityFramework;
using bakimonarim.dataaccess.Abstract;
using bakimonarim.entity;
using bakimonarim.entity.Identity;

namespace bakimonarim.dataaccess.Concrete
{
    public class MalzemeDal : EfEntityRepositoryBase<Malzeme, BakimOnarimDbContext>, IMalzemeDal
    {
        
    }
}