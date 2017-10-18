using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Foto : Base
    {
        public Foto()
        {
            Denuncias = new List<Denuncia>();
        }
        public string URL { get; set; }

        public ICollection<Denuncia> Denuncias { get; set; }
        public Residuo Residuo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
