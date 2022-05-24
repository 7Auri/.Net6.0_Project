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
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;
        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public IResult Add(Food food)
        {
            _foodDal.Add(food);
            return new SuccessResult(Messages.SuccessAdd);
        }


        public IResult Delete(Food food)
        {
           _foodDal.Delete(food);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Food>> GetAll()
        {
            return new SuccessDataResult<List<Food>>(_foodDal.GetAll(),Messages.SuccessListed);
        }

        public IDataResult<Food> GetById(int id)
        {
            return new SuccessDataResult<Food>(_foodDal.Get(x=>x.Id==id), Messages.SuccessListed);
        }

        public IDataResult<List<CatFoodDetails>> GetCatFoodDetails(int catId)
        {
            return new SuccessDataResult<List<CatFoodDetails>>(_foodDal.GetCatFoodDetails(x => x.CatId == catId), Messages.SuccessListed);
        }

        public IResult Update(Food food)
        {
            _foodDal.Update(food);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
