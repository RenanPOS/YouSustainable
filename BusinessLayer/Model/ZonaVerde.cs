using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class ZonaVerde : Base
    {
        [Key, ForeignKey("Localizacao")]
        public int LocalizacaoId { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual Localizacao Localizacao { get; set; }
    }
}
