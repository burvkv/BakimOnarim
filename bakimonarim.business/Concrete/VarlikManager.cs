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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.Concrete
{
    public class VarlikManager : IVarlikService
    {
        private readonly IVarlikDal _varlikDal;

        public VarlikManager(IVarlikDal varlikDal)
        {
            _varlikDal = varlikDal;
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IVarlikService.Get")]
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(VarlikValidator))]
        public IResult Add(Varlik varlik)
        {
            _varlikDal.Insert(varlik);
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IVarlikService.Get")]
        [LogAspect(typeof(FileLogger))]
        public IResult Delete(Varlik varlik)
        {
            _varlikDal.Delete(varlik);
            return new SuccessResult();
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Varlik>> GetAll(string key = null)
        {
            if (key == null)
            {
                return new SuccessDataResult<List<Varlik>>(_varlikDal.GetAll());
            }
            return new SuccessDataResult<List<Varlik>>(_varlikDal.GetAll(p => p.VarlikAdi.Contains(key)));

        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<Varlik> GetByFilter(string key = null)
        {
            if (key != null)
            {
                return new SuccessDataResult<Varlik>(_varlikDal.GetByFilter(p => p.VarlikKodu.Equals(key)));
            }
            return new ErrorDataResult<Varlik>(null, "Filtre boş olamaz.");
        }

        [ValidationAspect(typeof(VarlikValidator))]
        [TransactionScopeAspect]
        [PerformanceAspect(5)]
        [CacheRemoveAspect("IVarlikService.Get")]
        [LogAspect(typeof(FileLogger))]
        public IResult Update(Varlik varlik)
        {
            _varlikDal.Update(varlik);
            return new SuccessResult();
        }
    }
}
