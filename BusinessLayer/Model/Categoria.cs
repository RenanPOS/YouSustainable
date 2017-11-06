using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Categoria : Base
    {
        public Categoria()
        {
            Residuos = new List<Residuo>();
            Origens = new HashSet<Origem>();
            Periculosidades = new HashSet<Periculosidade>();
            Tipos = new HashSet<Tipo>();
            ComposicoesQuimica = new HashSet<ComposicaoQuimica>();
            PontosDescarte = new List<PontoDescarte>();
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodGrafico { get; set; }
        public string Cor { get; set; }

        public ICollection<Residuo> Residuos { get; set; }
        public ICollection<Origem> Origens { get; set; }
        public ICollection<Periculosidade> Periculosidades { get; set; }
        public ICollection<Tipo> Tipos { get; set; }
        public ICollection<ComposicaoQuimica> ComposicoesQuimica { get; set; }
        public ICollection<PontoDescarte> PontosDescarte { get; set; }
    }
}
