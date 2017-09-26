using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Evento : Base
    {
        public Evento(){
            Periodos = new List<Periodo>();
            Denuncias = new List<Denuncia>();
            Inscritos = new HashSet<Usuario>();
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; } 
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string URLFoto { get; set; }

        
        public ICollection<Periodo> Periodos { get; set; }
        public ICollection<Denuncia> Denuncias { get; set; }
        public ICollection<Usuario> Inscritos { get; set; }
        public Usuario Organizador { get; set; }
        public Area Area { get; set; }
    }
}
