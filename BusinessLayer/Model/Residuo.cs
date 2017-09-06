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

        private string Nome { get; set; }
        private string Descricao { get; set; }
        private string Estado { get; set; }
        private string Observacao { get; set; }

        public virtual ICollection<Foto> Fotos { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
