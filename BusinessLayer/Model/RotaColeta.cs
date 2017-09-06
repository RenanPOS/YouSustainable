using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class RotaColeta : Base
    {
        public RotaColeta()
        {
            PontosDescarte = new HashSet<PontoDescarte>();
        }

        private string Nome { get; set; }
        private string Status { get; set; }

        public virtual ICollection<PontoDescarte> PontosDescarte { get; set; }
        public virtual DataRota Data { get; set; }
        public virtual Area Area { get; set; }
    }
}
