using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class PeriodoDao : SqlServerDao
    {
        public List<Periodo> ListarPorEvento(Evento evento)
        {
            using(SqlServerDao dao = new PeriodoDao())
            {
                List<Periodo> periodos = dao.Buscar<Periodo>(p => p.Evento.Id == evento.Id);
                return periodos;
            }
            return null;
        }
    }
}
