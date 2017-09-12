using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Newtonsoft.Json;
using System.IO;

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
                var serializer = new JsonSerializer
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    ContractResolver = new NHibernateContractResolver()
                };
                return NHibernateContractResolver.gerarJSON(eventos);
            }
        }

        [HttpGet]
        [ActionName("CadastrarEvento")]
        public bool Inserir([FromUri]Evento evento)
        {
            using (EventoDao dao = new EventoDao())
            {
                try
                {
                    dao.Inserir(evento);
                    return true;
                }catch(Exception e)
                {
                    return false;
                }
            }
        }
    }
}
