using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMaltVitService
    {
        IDataResult<List<MaltVit>> GetAll();
        IDataResult<MaltVit> GetById(int id);
        IResult Add(MaltVit maltVit);
        IResult Update(MaltVit maltVit);
        IResult Delete(MaltVit maltVit);
    }
}
