using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Newtonsoft.Json;

namespace ServiceLayer.Controllers
{
    public class PontoDescarteController : ApiController
    {
        [HttpGet]
        [ActionName("CadastrarPontoDescarte")]
        public bool Inserir([FromUri]PontoDescarte pontoDescarte, [FromUri]Localizacao localizacao)
        {
            pontoDescarte.Localizacao = localizacao;
            PontoDescarteDao dao = new PontoDescarteDao();
            return dao.Inserir(pontoDescarte);
        }

        [HttpGet]
        [ActionName("ListarPontosDescarte")]
        public String ListarPontosDescarte()
        {
            List<PontoDescarte> pontosDescarte;
            PontoDescarteDao dao = new PontoDescarteDao();

            pontosDescarte = dao.ListarTodos();
                
            return JsonConvert.SerializeObject(pontosDescarte);
            
        }

        [HttpGet]
        [ActionName("ListarPontosDescarte")]
        public String ListarPontosDescarte(int id)
        {
            List<PontoDescarte> pontosDescarte;
            PontoDescarteDao dao = new PontoDescarteDao();

            pontosDescarte = dao.ListarTodos(id);

            return JsonConvert.SerializeObject(pontosDescarte);

        }

        [HttpGet]
        [ActionName("PontoDescarteDetail")]
        public String PontoDescarteDetail(int id)
        {
            PontoDescarteDao dao = new PontoDescarteDao();

            PontoDescarte ponto = dao.BuscarPorId(id);

            return JsonConvert.SerializeObject(ponto);
        }
    }
}
