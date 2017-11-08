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
    public class RotaColetaController : ApiController
    {
        [HttpGet]
        [ActionName("CadastrarRotaColeta")]
        public bool Inserir([FromUri]RotaColeta rotaColeta)
        {
            RotaColetaDao dao = new RotaColetaDao();

            var test = dao.Inserir(rotaColeta);

            return test;
        }

        [HttpGet]
        [ActionName("ListarRotas")]
        public String ListarRotas()
        {
            List<RotaColeta> rotas;
            RotaColetaDao dao = new RotaColetaDao();

            rotas = dao.ListarTodas();

            return JsonConvert.SerializeObject(rotas);

        }
    }
}
