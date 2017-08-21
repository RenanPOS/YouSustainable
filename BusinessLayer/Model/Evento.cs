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
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private string Bairro { get; set; }
        private string Rua { get; set; }
        private int Numero { get; set; }
        private string URLFoto { get; set; }
    }
}
