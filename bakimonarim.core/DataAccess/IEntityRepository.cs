using bakimonarim.core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.core.DataAccess
{
    public interface IEntityRepository<T> where T: class,IEntity,new() 
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByFilter(Expression<Func<T, bool>> filter);

    }
}
