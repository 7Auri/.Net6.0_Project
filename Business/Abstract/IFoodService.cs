using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFoodService
    {
        IDataResult<List<Food>> GetAll();
        IDataResult<Food> GetById(int id);
        IResult Add(Food food);
        IResult Update(Food food);
        IResult Delete(Food food);
    }
}
