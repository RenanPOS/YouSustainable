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
    public class EventoController : ApiController
    {
        [HttpGet]
        [ActionName("ListarEventos")]
        public string ListarEventos(int id_evento)
        {
            List<Evento> eventos;
            using (EventoDao dao = new EventoDao())
            {
                eventos = dao.BuscarEventos();
                if(eventos.Count > 0)
                {
                    PeriodoDao periodoDao = new PeriodoDao();
                    foreach(Evento evento in eventos)
                    {
                        evento.Periodos = periodoDao.ListarPorEvento(evento);
                    }
                }
                /*
                var serializer = new JsonSerializer
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    ContractResolver = new NHibernateContractResolver()
                };
                return NHibernateContractResolver.gerarJSON(eventos);
                */
                return JsonConvert.SerializeObject(eventos);
            }
        }

        [HttpGet]
        [ActionName("CadastrarEvento")]
        public int Inserir([FromUri]Evento evento)
        {
            using (EventoDao dao = new EventoDao())
            {
                try
                {
                    dao.Inserir(evento);
                    return evento.Id;
                }catch(Exception e)
                {
                    return 0;
                }
            }
        }
    }
}
