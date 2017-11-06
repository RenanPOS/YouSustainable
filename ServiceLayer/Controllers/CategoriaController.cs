using BusinessLayer.Dao;
using BusinessLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiceLayer.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoriaController : ApiController
    {
        [HttpGet]
        [ActionName("ListarTodasCategorias")]
        public string ListarTodasCategorias()
        {
            List<Categoria> categorias;
            using(CategoriaDao dao = new CategoriaDao())
            {
                categorias = dao.ListarTodas();
                /*
                if(categorias.Count > 0)
                {
                    SqlServerDao dao2 = new SqlServerDao();
                    
                    foreach(Categoria categoria in categorias)
                    {
                        categoria.Origens = dao2.ListarTodos<Origem>();
                        categoria.Periculosidades = dao2.Buscar<Periculosidade>(p => p.Categorias.Contains(categoria));
                        categoria.ComposicoesQuimica = dao2.Buscar<ComposicaoQuimica>(p => p.Categorias.Contains(categoria));
                        categoria.Tipos = dao2.Buscar<Tipo>(p => p.Categorias.Contains(categoria));
                    }
                }
                */
                return JsonConvert.SerializeObject(categorias);
            }
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
        [HttpPost]
        [ActionName("SalvarCategoria")]
        public int SalvarCategoria([FromBody] Categoria categoria)
        {
            CategoriaDao dao = new CategoriaDao();
            if(categoria != null)
            {
                dao.Inserir(categoria);
                if(categoria.Id > 0)
                {
                    return categoria.Id;
                }
            }
            return 0;
        }
    }
}
