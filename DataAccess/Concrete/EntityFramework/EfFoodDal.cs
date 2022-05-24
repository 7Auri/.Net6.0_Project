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
    public class EfFoodDal : EfEntityRepositoryBase<Food, PDbContext>, IFoodDal
    {

        public List<CatFoodDetails> GetCatFoodDetails(Expression<Func<CatFoodDetails, bool>> filter)
        {
            using (PDbContext context = new())
            {
                var result = from food in context.Foods
                             join cat in context.Cats
                             on food.Cat.Id equals cat.Id

                             select new CatFoodDetails
                             {
                                 FoodId = food.Id,
                                 DryFood = food.DryFood,
                                 WetFood = food.WetFood,
                                 CatId = cat.Id,
                                 CatName = cat.Name

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
