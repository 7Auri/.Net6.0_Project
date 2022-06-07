using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RabiesManager : IRabiesService
    {
        IRabiesDal _rabiesDal;
        public RabiesManager(IRabiesDal rabiesDal)
        {
            _rabiesDal = rabiesDal;
        }

        public IResult Add(Rabies rabies)
        {
            _rabiesDal.Add(rabies);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Rabies rabies)
        {
            _rabiesDal.Delete(rabies);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Rabies>> GetAll()
        {
            return new SuccessDataResult<List<Rabies>>(_rabiesDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<Rabies> GetById(int id)
        {
            return new SuccessDataResult<Rabies>(_rabiesDal.Get(x=>x.RabiesId==id),Messages.SuccessListed);
        }

        public IResult Update(Rabies rabies)
        {
            _rabiesDal.Update(rabies);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
