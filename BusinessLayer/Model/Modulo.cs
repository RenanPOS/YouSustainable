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
        public Modulo()
        {
            Privilegios = new List<Privilegio>();
        }

        public string Nome { get; set; }

        public virtual ICollection<Privilegio> Privilegios { get; set; }
    }
}
