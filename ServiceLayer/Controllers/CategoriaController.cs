using BusinessLayer.Dao;
using BusinessLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceLayer.Controllers
{
    public class CategoriaController : ApiController
    {
        [HttpGet]
        [ActionName("ListarTodasCategorias")]
        public string ListarTodasCategorias(string categoria)
        {
            List<Categoria> categorias;
            using(CategoriaDao dao = new CategoriaDao())
            {
                categorias = dao.ListarTodas(categoria);
            }
            return JsonConvert.SerializeObject(categorias);
        }

        [HttpGet]
        [ActionName("ListarOrigens")]
        public string ListarOrigens([FromUri] Categoria categoria)
        {
            List<Origem> origens;
            using (CategoriaDao dao = new CategoriaDao())
            {
                origens = dao.ListarOrigem(categoria);
            }
            return JsonConvert.SerializeObject(origens);
        }

        [HttpGet]
        [ActionName("ListarPericulosidades")]
        public string ListarPericulosidades([FromUri] Categoria categoria)
        {
            List<Periculosidade> periculosidades;
            using (CategoriaDao dao = new CategoriaDao())
            {
                periculosidades = dao.ListarPericulosidade(categoria);
            }
            return JsonConvert.SerializeObject(periculosidades);
        }

        [HttpGet]
        [ActionName("ListarTipos")]
        public string ListarTipos([FromUri] Categoria categoria)
        {
            List<Tipo> tipos;
            using (CategoriaDao dao = new CategoriaDao())
            {
                tipos = dao.ListarTipo(categoria);
            }
            return JsonConvert.SerializeObject(tipos);
        }
        [HttpGet]
        [ActionName("ListarComposicaoQuimica")]
        public string ListarComposicaoQuimica([FromUri] Categoria categoria)
        {
            List<ComposicaoQuimica> compQuimica;
            using (CategoriaDao dao = new CategoriaDao())
            {
                compQuimica = dao.ListarComposicaoQuimica(categoria);
            }
            return JsonConvert.SerializeObject(compQuimica);
        }
    }
}
