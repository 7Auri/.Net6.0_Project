using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICatDal : IEntityRepository<Cat>
    {
        List<CatVaccineDetails> GetCatVaccineDetails(Expression<Func<CatVaccineDetails, bool>> filter);
        List<CatAllDetails> GetCatAllDetails(Expression<Func<CatAllDetails, bool>> filter);
    }
}
