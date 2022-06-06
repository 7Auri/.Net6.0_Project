using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DryFood:CommonFood
    {
        [Key]
        public int DryFoodId { get; set; }

    }
}
