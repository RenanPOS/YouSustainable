﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Categoria : Base
    {
        public Categoria()
        {
            Residuos = new List<Residuo>();
            Origens = new HashSet<Origem>();
            Periculosidades = new HashSet<Periculosidade>();
            Tipos = new HashSet<Tipo>();
            ComposicoesQuimica = new HashSet<ComposicaoQuimica>();
            PontosDescarte = new List<PontoDescarte>();
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodGrafico { get; set; }
        public string Cor { get; set; }

        public virtual ICollection<Residuo> Residuos { get; set; }
        public virtual ICollection<Origem> Origens { get; set; }
        public virtual ICollection<Periculosidade> Periculosidades { get; set; }
        public virtual ICollection<Tipo> Tipos { get; set; }
        public virtual ICollection<ComposicaoQuimica> ComposicoesQuimica { get; set; }
        public virtual ICollection<PontoDescarte> PontosDescarte { get; set; }
    }
}
