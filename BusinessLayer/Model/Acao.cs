using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Acao : Base
    {
        private string Nome { get; set; }
        private string NomePadrao { get; set; }
        private float Pontuacao { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Administrador Administrador { get; set; }
    }
}
