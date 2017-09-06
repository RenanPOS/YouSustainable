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
        private string URL { get; set; }

        public virtual ICollection<Denuncia> Denuncias { get; set; }
        public virtual Residuo Residuo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
