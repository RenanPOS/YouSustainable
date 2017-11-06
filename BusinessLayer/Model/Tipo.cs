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
        public string Descricao { get; set; }
        public int Peso { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
    }
}
