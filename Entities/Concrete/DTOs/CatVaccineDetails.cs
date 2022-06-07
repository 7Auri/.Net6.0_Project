using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CatVaccineDetails
    {
        public int CatId { get; set; }
        public string? CatName { get; set; }
        public bool? RabiesVaccine { get; set; }
        public DateTime? RabiesDateOfCreation { get; set; }

        public bool? FvrcpVaccine { get; set; }
        public DateTime? FvrcpDateOfCreation { get; set; }

        public bool? LeukemiaVaccine { get; set; }
        public DateTime? LeukemiaDateOfCreation { get; set; }
    }
}
