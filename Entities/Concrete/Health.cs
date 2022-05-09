using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Health
    {
        public int Id { get; set; }
        public string? Sterilization { get; set; }
        public string? Disease { get; set; }
    }
}
