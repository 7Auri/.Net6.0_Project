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
    public class LeukemiaManager : ILeukemiaService
    {
        ILeukemiaDal _leukemiaDal;
        public LeukemiaManager(ILeukemiaDal leukemiaDal)
        {
            _leukemiaDal = leukemiaDal;
        }

        public IResult Add(Leukemia leukemia)
        {
            _leukemiaDal.Add(leukemia);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Leukemia leukemia)
        {
            _leukemiaDal.Delete(leukemia);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Leukemia>> GetAll()
        {
            return new SuccessDataResult<List<Leukemia>>(_leukemiaDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<Leukemia> GetById(int id)
        {
            return new SuccessDataResult<Leukemia>(_leukemiaDal.Get(x => x.LeukemiaId == id), Messages.SuccessListed);
        }

        public IResult Update(Leukemia leukemia)
        {
            _leukemiaDal.Update(leukemia);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
