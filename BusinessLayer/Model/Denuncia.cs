using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    [Serializable]
    public class Denuncia : Base
    {
        private string Descricao { get; set; }
        private string Estado { get; set; }

        public virtual Evento Evento { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Foto Foto { get; set; }

    }
}
