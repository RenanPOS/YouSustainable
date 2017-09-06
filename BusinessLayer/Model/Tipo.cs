using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Tipo : Base
    {
        private string Descricao { get; set; }
        private int Peso { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
