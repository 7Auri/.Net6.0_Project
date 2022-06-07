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
    public interface IRabiesService
    {
        IDataResult<List<Rabies>> GetAll();
        IDataResult<Rabies> GetById(int id);
        IResult Add(Rabies rabies);
        IResult Update(Rabies rabies);
        IResult Delete(Rabies rabies);
    }
}
