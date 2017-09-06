﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Origem : Base
    {
        public Origem()
        {
            Categorias = new HashSet<Categoria>();
        }

        private string Descricao { get; set; }
        private int Peso { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}