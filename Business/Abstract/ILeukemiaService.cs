using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ILeukemiaService
    {
        IDataResult<List<Leukemia>> GetAll();
        IDataResult<Leukemia> GetById(int id);
        IResult Add(Leukemia leukemia);
        IResult Update(Leukemia leukemia);
        IResult Delete(Leukemia leukemia);
    }
}
