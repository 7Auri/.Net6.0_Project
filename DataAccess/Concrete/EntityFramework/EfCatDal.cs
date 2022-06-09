using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCatDal : EfEntityRepositoryBase<Cat, PDbContext>, ICatDal
    {
        public List<CatVaccineDetails> GetCatVaccineDetails(Expression<Func<CatVaccineDetails, bool>> filter)
        {
            using (PDbContext context = new())
            {
                var result = from cat in context.Cats
                             join fvrcp in context.Fvrcps
                             on cat.Id equals fvrcp.CatId
                             join leukemia in context.Leukemias
                             on cat.Id equals leukemia.CatId
                             join rabies in context.Rabies
                             on cat.Id equals rabies.CatId

                             select new CatVaccineDetails
                             {
                                 
                                 CatId = cat.Id,
                                 CatName = cat.Name,
                                 LeukemiaVaccine=leukemia.Vaccine,
                                 LeukemiaDateOfCreation=leukemia.DateOfCreation,
                                 RabiesVaccine=rabies.Vaccine,
                                 RabiesDateOfCreation=rabies.DateOfCreation,    
                                 FvrcpVaccine=fvrcp.Vaccine,
                                 FvrcpDateOfCreation=fvrcp.DateOfCreation,  
                                


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }



        }
        public List<CatAllDetails> GetCatAllDetails(Expression<Func<CatAllDetails, bool>> filter)
        {
            using (PDbContext context = new())
            {
                var result = from cat in context.Cats
                             join maltVit in context.MaltVits
                             on cat.Id equals maltVit.CatId
                            join healt in context.Healths
                            on cat.Id equals healt.CatId
                         
                            

                             select new CatAllDetails
                             {

                                 CatId = cat.Id,
                                 CatName = cat.Name,
                                 Age = cat.Age,
                                 Sterilization=healt.Sterilization,
                                 Disease=healt.Disease, 
                                 MaltTime=maltVit.MaltTime,
                                 VitTime=maltVit.VitTime,
                                




                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }



        }

    }
}
