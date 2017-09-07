using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class EventoDao : SqlServerDao
    {
        public Evento BuscarEventoNome(string nome)
        {
            using(SqlServerDao dao = new EventoDao())
            {
                Evento evento = dao.Buscar<Evento>(p => p.Nome.Equals(nome)).FirstOrDefault();
                return evento;
            }
        }

        public List<Evento> BuscarEventos()
        {
            using (SqlServerDao dao = new EventoDao())
            {
                //Evento evento = dao.Buscar<Evento>(p => p.Nome.Equals(nome)).FirstOrDefault();
                List<Evento> eventos = dao.Buscar<Evento>(p => p.Id > 0);
                return eventos;
            }
        }

        public void Inserir(Evento evento)
        {
            using (SqlServerDao dao = new EventoDao())
            {
                //Evento evento = dao.Buscar<Evento>(p => p.Nome.Equals(nome)).FirstOrDefault();
                    dao.Inserir(evento);
            }
        }
    }
}
