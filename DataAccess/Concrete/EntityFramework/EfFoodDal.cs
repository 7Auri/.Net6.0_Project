using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System.Linq.Expressions;

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
                             on food.CatId equals cat.Id
                             join dry in context.DryFoods
                             on food.DryFood.DryFoodId equals dry.DryFoodId
                             join wet in context.WetFoods
                             on food.WetFood.WetFoodId equals wet.WetFoodId

                             select new CatFoodDetails
                             {
                                 FoodId = food.Id,
                                 CatId = cat.Id,
                                 CatName = cat.Name,
                                 DryFoodName = dry.Name,
                                 WetFoodName = wet.Name


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        
    }
}
