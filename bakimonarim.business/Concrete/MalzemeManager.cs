using System.Linq.Expressions;
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
    public class MalzemeManager : IMalzemeService
    {
        private readonly IMalzemeDal _malzemeDal;

        public MalzemeManager(IMalzemeDal malzemeDal)
        {
            _malzemeDal = malzemeDal;
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IVarlikService.Get")]
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(VarlikValidator))]
        public IResult Add(Malzeme malzeme)
        {
            _malzemeDal.Insert(malzeme);
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IVarlikService.Get")]
        [LogAspect(typeof(FileLogger))]
        public IResult Delete(Malzeme malzeme)
        {
            _malzemeDal.Delete(malzeme);
            return new SuccessResult();
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Malzeme>> GetAll(string key = null)
        {
            if (key!=null)
            {
                return new SuccessDataResult<List<Malzeme>>(_malzemeDal.GetAll(m=>m.MalzemeAd.Contains(key)));
            }
                return new SuccessDataResult<List<Malzeme>>(_malzemeDal.GetAll());

        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<Malzeme> GetByFilter(string key = null)
        {
            if (key ==null)
            {
                return new ErrorDataResult<Malzeme>(null,"Filtre Boþ Olamaz!.");
            }
           
                return new SuccessDataResult<Malzeme>(_malzemeDal.GetByFilter(m=>m.MalzemeID==int.Parse(key)));
            
        }

        [ValidationAspect(typeof(VarlikValidator))]
        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IVarlikService.Get")]
        [LogAspect(typeof(FileLogger))]
        public IResult Update(Malzeme malzeme)
        {
            _malzemeDal.Update(malzeme);
            return new SuccessResult();
        }
    }
}