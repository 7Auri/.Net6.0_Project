using Core.Entities;

namespace Entities.Concrete.DTOs
{
    public class CommonVaccine : IEntity
    {
       
        public bool? Vaccine { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int Count { get; set; }
        public int CatId { get; set; }
        
    }
}
