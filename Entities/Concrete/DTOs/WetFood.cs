using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WetFood: CommonFood
    {
        [Key]
        public int WetFoodId { get; set; }

    }
}
