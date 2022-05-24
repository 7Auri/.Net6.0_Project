using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Health : IEntity
    {
        public int Id { get; set; }
        public string? Sterilization { get; set; }
        public string? Disease { get; set; }
        public Cat? Cat { get; set; }
    }
}
