using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Modulo : Base
    {
        private string Nome { get; set; }

        public virtual Privilegio Privilegio { get; set; }
    }
}
