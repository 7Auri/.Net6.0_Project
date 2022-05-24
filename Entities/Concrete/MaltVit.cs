using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaltVit : IEntity
    {
        public int Id { get; set; }
        public bool? Malt { get; set; }
        public DateTime? MaltTime { get; set; }
        public bool? Vitamin { get; set; }
        public DateTime? VitTime { get; set; }
        public Cat? Cat { get; set; }
    } 
}
