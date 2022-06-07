using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FvrcpManager : IFvrcpService
    {
        IFvrcpDal _fvrcpDal;
        public FvrcpManager(IFvrcpDal fvrcpDal)
        {
            _fvrcpDal = fvrcpDal;
        }

        public IResult Add(Fvrcp fvrcp)
        {
            _fvrcpDal.Add(fvrcp);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Fvrcp fvrcp)
        {
            _fvrcpDal.Delete(fvrcp);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Fvrcp>> GetAll()
        {
            return new SuccessDataResult<List<Fvrcp>>(_fvrcpDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<Fvrcp> GetById(int id)
        {
            return new SuccessDataResult<Fvrcp>(_fvrcpDal.Get(x => x.FvrcpId == id), Messages.SuccessListed);
        }

        public IResult Update(Fvrcp fvrcp)
        {
            _fvrcpDal.Update(fvrcp);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
