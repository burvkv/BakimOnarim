using System.Linq.Expressions;
using bakimonarim.core.Utilities.Results;
using bakimonarim.entity;

namespace bakimonarim.business.Abstracts
{
    public interface IMalzemeService
    {
        IDataResult<List<Malzeme>> GetAll(string key = null);
        IDataResult<Malzeme> GetByFilter(string key = null);
        IResult Add(Malzeme malzeme);
        IResult Delete(Malzeme malzeme);  
        IResult Update(Malzeme malzeme);

    }
}
