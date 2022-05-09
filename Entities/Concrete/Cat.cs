using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cat
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
