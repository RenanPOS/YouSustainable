    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Usuario : Base
    {
        public Usuario()
        {
            Eventos = new HashSet<Evento>();
            Denuncias = new List<Denuncia>();
            Fotos = new List<Foto>();
            Residuos = new List<Residuo>();
            Localizacoes = new List<Localizacao>();
            Alertas = new List<Alerta>();
            Acoes = new HashSet<Acao>();
            Privilegios = new List<Privilegio>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public float Pontos { get; set; }
        public int RaioBusca { get; set; }

        public ICollection<Evento> Eventos { get; set; }
        public ICollection<Denuncia> Denuncias { get; set; }
        public ICollection<Foto> Fotos { get; set; }
        public ICollection<Residuo> Residuos { get; set; }
        public ICollection<Alerta> Alertas { get; set; }
        public ICollection<Acao> Acoes { get; set; }
        public ICollection<Localizacao> Localizacoes { get; set; }
        public ICollection<Privilegio> Privilegios { get; set; }
    }
}
