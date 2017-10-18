using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Alerta : Base
    {
        public string Descricao { get; set; }

        public PontoDescarte PontoDescarte { get; set; }
        public Usuario Usuario { get; set; }
    }
}
