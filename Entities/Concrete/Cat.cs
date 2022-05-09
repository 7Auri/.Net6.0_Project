using Core.Entities;

namespace Entities.Concrete
{
    public class Cat : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Color { get; set; }
        public int Age { get; set; }
        public DateTime? Birtday { get; set; }
        public string? Breed { get; set; }
    }
}
