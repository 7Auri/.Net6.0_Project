using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CommonVaccine
    {
        public bool? Vaccine { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int Count { get; set; }
    }
}
