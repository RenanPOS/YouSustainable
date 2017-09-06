using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Privilegio : Base
    {
        private char Nivel { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Area Area { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
