using bakimonarim.core.Utilities.Results;
using bakimonarim.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.Abstracts
{
    public interface IVarlikService
    {
        IDataResult<List<Varlik>> GetAll(string key = null);
        IDataResult<Varlik> GetByFilter(string key = null);
        IResult Add(Varlik varlik);
        IResult Delete(Varlik varlik);  
        IResult Update(Varlik varlik);

    }
}
