using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Periodo : Base
    {
        private DateTime HorarioInical { get; set; }
        private DateTime HorarioFinal { get; set; }

        public virtual Evento Evento { get; set; }
    }
}
