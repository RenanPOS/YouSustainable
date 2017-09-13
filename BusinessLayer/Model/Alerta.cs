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

        public virtual PontoDescarte PontoDescarte { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
