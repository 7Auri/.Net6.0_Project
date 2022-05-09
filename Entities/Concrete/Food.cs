using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Food : IEntity
    {
        public int Id { get; set; }
        public WetFood? WetFood{ get; set; }
        public DryFood? DryFood{ get; set; } 
    }
}
