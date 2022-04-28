using bakimonarim.core.Utilities.Results;
using bakimonarim.entity;

namespace bakimonarim.business.Abstracts
{
    public interface IVGrupService
    {
        IDataResult<List<VGrup>> GetAll(string key = null);
        IDataResult<VGrup> GetByFilter(string key = null);
        IResult Add(VGrup varlik);
        IResult Delete(VGrup varlik);
        IResult Update(VGrup varlik);

    }
}
