﻿using Core.Entities;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Leukemia:CommonVaccine
    {
        public int LeukemiaId { get; set; }
       
    }
}
