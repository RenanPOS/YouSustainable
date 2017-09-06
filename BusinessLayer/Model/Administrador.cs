using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
            Informativos = new HashSet<Informativo>();
        }

        public virtual ICollection<Informativo> Informativos { get; set; }
    }
}
