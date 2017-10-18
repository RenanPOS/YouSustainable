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

        public string Estado { get; set; }
        public bool EhPArticular { get; set; }

        public Area Area { get; set; }
        public Categoria Categoria { get; set; }
        public Localizacao Localizacao { get; set; }
        public ZonaVerde ZonaVerde { get; set; }
        public List<Alerta> Alertas { get; set; }
        public ICollection<RotaColeta> RotasColeta { get; set; }

    }
}
