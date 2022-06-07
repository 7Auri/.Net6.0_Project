using Core.Utilities.Result;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICatService
    {
        IDataResult<List<Cat>> GetAll();
        IDataResult<Cat> GetById(int id);
        IResult Add(Cat cat);
        IResult Update(Cat cat);
        IResult Delete(Cat cat);
        IDataResult<List<CatVaccineDetails>> GetCatVaccineDetails(int catId);

    }
}
