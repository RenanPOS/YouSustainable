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
    public class AlertaController : ApiController
    {
        /*[HttpGet]
        [ActionName("CadastrarAlerta")]
        public bool Inserir([FromUri]ZonaVerde zonaVerde, [FromUri]Localizacao localizacao)
        {
            zonaVerde.Localizacao = localizacao;

            ZonaVerdeDao zonaVerdeDao = new ZonaVerdeDao();
            var test = zonaVerdeDao.Inserir(zonaVerde);

            return true;
        }*/

        [HttpGet]
        [ActionName("ListarAlertas")]
        public String ListarAlertas()
        {
            List<Alerta> alertas;
            AlertaDao dao = new AlertaDao();

            alertas = dao.ListarTodos();

            return JsonConvert.SerializeObject(alertas);

        }
    }
}
