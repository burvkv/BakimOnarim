using bakimonarim.business.Abstracts;
using bakimonarim.business.Validation.FluentValidation;
using bakimonarim.core.Aspect.Autofac.Caching;
using bakimonarim.core.Aspect.Autofac.Logging;
using bakimonarim.core.Aspect.Autofac.Performance;
using bakimonarim.core.Aspect.Autofac.Transaction;
using bakimonarim.core.Aspect.Autofac.Validation;
using bakimonarim.core.CrossCuttingConcerns.Logging.Log4Net.Loggers.FileLogger;
using bakimonarim.core.Utilities.Results;
using bakimonarim.dataaccess.Abstract;
using bakimonarim.entity;

namespace bakimonarim.business.Concrete
{
    public class VGrupManager : IVGrupService
    {
        private readonly IVGrupDal _vGrupDal;

        public VGrupManager(IVGrupDal vGrupDal)
        {
            _vGrupDal = vGrupDal;
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IProjectService.Get")]
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(VGrupValidator))]
        public IResult Add(VGrup vGrup)
        {
            _vGrupDal.Insert(vGrup);
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IProjectService.Get")]
        [LogAspect(typeof(FileLogger))]
        public IResult Delete(VGrup vGrup)
        {
            _vGrupDal.Delete(vGrup);
            return new SuccessResult();
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<VGrup>> GetAll(string key = null)
        {
            if (key == null)
            {
                return new SuccessDataResult<List<VGrup>>(_vGrupDal.GetAll());
            }
            return new SuccessDataResult<List<VGrup>>(_vGrupDal.GetAll(p => p.GrupMarka.Contains(key)));

        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<VGrup> GetByFilter(string key = null)
        {
            if (key != null)
            {
                return new SuccessDataResult<VGrup>(_vGrupDal.GetByFilter(p => p.GrupMarka.Equals(key)));
            }
            return new ErrorDataResult<VGrup>(null, "Filtre boş olamaz.");
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IProjectService.Get")]
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(VGrupValidator))]
        public IResult Update(VGrup vGrup)
        {
            _vGrupDal.Update(vGrup);
            return new SuccessResult();
        }
    }
}
