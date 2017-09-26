using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Informativo : Base
    {
        public Informativo()
        {
            Administradores = new HashSet<Administrador>();
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public ICollection<Administrador> Administradores { get; set; }
    }
}
