﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class DataRota : Base
    {
        public int DiasSemana { get; set; }
        public DateTime DiaUnico { get; set; }
        public DateTime Horario { get; set; }

        public virtual RotaColeta RotaColeta { get; set; }
    }
}
