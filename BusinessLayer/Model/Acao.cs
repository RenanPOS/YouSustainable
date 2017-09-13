﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Model
{
    public class Acao : Base
    {
        public string Nome { get; set; }
        public string NomePadrao { get; set; }
        public float Pontuacao { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Administrador Administrador { get; set; }
    }
}
