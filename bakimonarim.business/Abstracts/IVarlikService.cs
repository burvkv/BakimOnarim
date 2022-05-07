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
        IDataResult<List<Varlik2>> GetAll(string key = null);
        IDataResult<Varlik2> GetByFilter(string key = null);
        IResult Add(Varlik2 varlik);
        IResult Delete(Varlik2 varlik);  
        IResult Update(Varlik2 varlik);

    }
}
