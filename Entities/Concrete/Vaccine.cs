using Core.Entities;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vaccine : IEntity
    {
        public int Id { get; set; }
        public int RabiesId { get; set; }
        public Rabies? Rabies { get; set; }
        public int LeukemiaId { get; set; }
        public Leukemia? Leukemia { get; set; }
        public int FvrcpId { get; set; }
        public Fvrcp? Fvrcp { get; set; }
        public Cat? Cat { get; set; }


    }
}
