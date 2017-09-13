using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class ZonaVerde : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual Localizacao Localizacao { get; set; }
    }
}
