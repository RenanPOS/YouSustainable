using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Area : Base
    {
        public Area()
        {
            Privilegios = new List<Privilegio>();
            Eventos = new List<Evento>();
            RotasColeta = new List<RotaColeta>();
            PontosDescarte = new List<PontoDescarte>();
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<Privilegio> Privilegios { get; set; }
        public ICollection<Evento> Eventos { get; set; }
        public ICollection<RotaColeta> RotasColeta { get; set; }
        public ICollection<PontoDescarte> PontosDescarte { get; set; }

    }
}
