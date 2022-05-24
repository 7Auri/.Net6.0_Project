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
    public class MaltVitManager : IMaltVitService
    {
        IMaltVitDal _maltVitDal;
        public MaltVitManager(IMaltVitDal maltVitDal)
        {
            _maltVitDal = maltVitDal;
        }

        public IResult Add(MaltVit maltVit)
        {
            _maltVitDal.Add(maltVit);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(MaltVit maltVit)
        {
            _maltVitDal.Delete(maltVit);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<MaltVit>> GetAll()
        {
            return new SuccessDataResult<List<MaltVit>>(_maltVitDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<MaltVit> GetById(int id)
        {
            return new SuccessDataResult<MaltVit>(_maltVitDal.Get(x=>x.Id==id), Messages.SuccessListed);
        }

        public IResult Update(MaltVit maltVit)
        {
            _maltVitDal.Update(maltVit);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
