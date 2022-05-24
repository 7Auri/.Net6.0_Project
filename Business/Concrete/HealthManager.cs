using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HealthManager : IHealthService
    {
        IHealthDal _healthDal;
        public HealthManager(IHealthDal healthDal)
        {
            _healthDal = healthDal;
        }

        public IResult Add(Health health)
        {
           _healthDal.Add(health);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Health health)
        {
            _healthDal.Delete(health);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Health>> GetAll()
        {
            return new SuccessDataResult<List<Health>>(_healthDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<Health> GetById(int id)
        {
            return new SuccessDataResult<Health>(_healthDal.Get(x=>x.Id==id),Messages.SuccessListed) ;
        }

        public IResult Update(Health health)
        {
            _healthDal.Update(health);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
