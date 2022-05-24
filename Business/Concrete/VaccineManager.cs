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
    public class VaccineManager : IVaccineService
    {
        IVaccineDal _vaccineDal;
        public VaccineManager(IVaccineDal vaccineDal)
        {
            _vaccineDal = vaccineDal;
        }

        public IResult Add(Vaccine vaccine)
        {
            _vaccineDal.Add(vaccine);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Vaccine vaccine)
        {
            _vaccineDal.Delete(vaccine);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Vaccine>> GetAll()
        {
            return new SuccessDataResult<List<Vaccine>>(_vaccineDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<Vaccine> GetById(int id)
        {
            return new SuccessDataResult<Vaccine>(_vaccineDal.Get(x=>x.Id==id),Messages.SuccessListed);
        }

        public IResult Update(Vaccine vaccine)
        {
            _vaccineDal.Update(vaccine);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
