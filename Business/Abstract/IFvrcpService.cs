using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFvrcpService
    {
        IDataResult<List<Fvrcp>> GetAll();
        IDataResult<Fvrcp> GetById(int id);
        IResult Add(Fvrcp fvrcp);
        IResult Update(Fvrcp fvrcp);
        IResult Delete(Fvrcp fvrcp);
    }
}
