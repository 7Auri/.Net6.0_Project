using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHealthService
    {
        IDataResult<List<Health>> GetAll();
        IDataResult<Health> GetById(int id);
        IResult Add(Health health);
        IResult Update(Health health);
        IResult Delete(Health health);
    }
}
