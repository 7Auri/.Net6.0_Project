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
    public class CatManager : ICatService
    {
        ICatDal _catDal;
        public CatManager(ICatDal catDal)
        {
            _catDal = catDal;
        }

        public IResult Add(Cat cat)
        {
           _catDal.Add(cat);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Cat cat)
        {
           _catDal.Delete(cat); 
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Cat>> GetAll()
        {
           return new SuccessDataResult<List<Cat>>(_catDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<Cat> GetById(int id)
        {
            return new SuccessDataResult<Cat>(_catDal.Get(x=>x.Id==id), Messages.SuccessListed);
        }

        public IDataResult<List<CatVaccineDetails>> GetCatVaccineDetails(int catId)
        {
            return new SuccessDataResult<List<CatVaccineDetails>>(_catDal.GetCatVaccineDetails(x => x.CatId == catId), Messages.SuccessListed);

        }

        public IResult Update(Cat cat)
        {
            _catDal.Update(cat);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
