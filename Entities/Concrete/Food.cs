using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Food : IEntity
    {
        public int Id { get; set; }

        [ForeignKey("WetFoodId")]
        public int WetFoodId { get; set; }
        public WetFood WetFood { get; set; }
   

        [ForeignKey("DryFoodId")]
        public int DryFoodId { get; set; }
        public DryFood DryFood { get; set; }

        public int CatId { get; set; }
    }
}
