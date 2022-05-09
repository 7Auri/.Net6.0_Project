using Core.Entities;

namespace Entities.Concrete.DTOs
{
    public class CommonVaccine : IDto
    {
        public int Id { get; set; }
        public bool? Vaccine { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int Count { get; set; }
    }
}
