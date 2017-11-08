using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class RotaColeta : Base
    {
        public RotaColeta()
        {
            PontosDescarte = new List<PontoDescarte>();
        }

        [ForeignKey("Area")]
        public int AreaId { get; set; }

        public string Nome { get; set; }
        public string Status { get; set; }

        public ICollection<PontoDescarte> PontosDescarte { get; set; }
        public DataRota Data { get; set; }
        public Area Area { get; set; }
    }
}
