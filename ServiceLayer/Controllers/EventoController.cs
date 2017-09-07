using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Dao;
using BusinessLayer.Model;

namespace ServiceLayer.Controllers
{
    public class EventoController : ApiController
    {
        [HttpGet]
        [ActionName("ListarEventos")]
        public List<Evento> ListarEventos(int id_evento)
        {
            using (EventoDao dao = new EventoDao())
            {
                List<Evento> eventos = dao.BuscarEventos();
                return eventos;
            }
        }

        [HttpGet]
        [ActionName("Inserir")]
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
