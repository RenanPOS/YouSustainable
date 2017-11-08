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
        [HttpGet]
        [ActionName("CadastrarAlerta")]
        public bool Inserir([FromUri]Alerta alerta, [FromUri]PontoDescarte pontoDescarte)
        {
            alerta.PontoDescarte = pontoDescarte;
            alerta.DataCriacao = DateTime.Now;
            alerta.DataAtualizacao = DateTime.Now;

            SqlServerDao sqlDao = new SqlServerDao();
           
            var ponto = sqlDao.BuscarPorId<PontoDescarte>(alerta.PontoDescarte.Id);
            ponto.Alertas.Add(alerta);
            ponto.Estado = "Inutilizável";
            sqlDao.Atualizar<PontoDescarte>(ponto);

            return true;
        }

        [HttpGet]
        [ActionName("ListarAlertas")]
        public String ListarAlertas()
        {
            List<Alerta> alertas;
            AlertaDao dao = new AlertaDao();

            alertas = dao.ListarTodos();

            return JsonConvert.SerializeObject(alertas);

        }

        /*[HttpGet]
        [ActionName("BuscarPontoDescarte")]
        public String BuscarPontoDescarte(int id)
        {
            AlertaDao dao = new AlertaDao();

            PontoDescarte ponto = dao.BuscarPontoDescarte(id);

            return JsonConvert.SerializeObject(ponto);
        }*/
    }
}
