using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class PontoDescarte : Base
    {
        public PontoDescarte()
        {
            Alertas = new List<Alerta>();
            RotasColeta = new HashSet<RotaColeta>();
        }

        private string Estado { get; set; }
        private bool EhPArticular { get; set; }

        public virtual Area Area { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Localizacao Localizacao { get; set; }
        public virtual ZonaVerde ZonaVerde { get; set; }
        public virtual ICollection<Alerta> Alertas { get; set; }
        public virtual ICollection<RotaColeta> RotasColeta { get; set; }

    }
}
