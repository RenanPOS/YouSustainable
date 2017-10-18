using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Residuo : Base
    {
        public Residuo()
        {
            Fotos = new List<Foto>();
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }
        public string Observacao { get; set; }

        public ICollection<Foto> Fotos { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario Usuario { get; set; }
    }
}
