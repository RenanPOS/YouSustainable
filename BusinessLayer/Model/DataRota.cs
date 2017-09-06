using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class DataRota : Base
    {
        private int DiasSemana { get; set; }
        private DateTime DiaUnico { get; set; }
        private DateTime Horario { get; set; }

        public virtual RotaColeta RotaColeta { get; set; }
    }
}
