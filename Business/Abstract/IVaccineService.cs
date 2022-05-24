using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVaccineService
    {
        IDataResult<List<Vaccine>> GetAll();
        IDataResult<Vaccine> GetById(int id);
        IResult Add(Vaccine vaccine);
        IResult Update(Vaccine vaccine);
        IResult Delete(Vaccine vaccine);
    }
}
