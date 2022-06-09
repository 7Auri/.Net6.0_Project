using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CatAllDetails:IDto
    {
        public int CatId { get; set; }
        public string? CatName { get; set; }
        public int Age { get; set; }
        public string? Disease { get; set; }
        public string? Sterilization { get; set; }
        public DateTime? MaltTime { get; set; }
        public DateTime? VitTime { get; set; }

    }
}
