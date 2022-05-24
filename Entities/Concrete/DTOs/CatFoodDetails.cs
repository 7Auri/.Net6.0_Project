using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CatFoodDetails
    {
        public int CatId { get; set; }
        public string? CatName { get; set; }
        public int FoodId { get; set; }
        public string? WetFoodName { get; set; }
        public string? DryFoodName { get; set; }
       

    }
}
