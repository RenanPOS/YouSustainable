using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class AlertaDao
    {
        public void Inserir(Alerta alerta)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Alerta>(alerta);
            }
        }

        public List<Alerta> ListarTodos()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                var lista = dao.ListarTodos<Alerta>();
                lista.OrderBy(a => a.DataAtualizacao);
                return lista;
            }
        }

        /*public PontoDescarte BuscarPontoDescarte(int id)
        {
            SqlServerDao dao = new SqlServerDao();
            Alerta alerta = dao.BuscarPorId<Alerta>(id);
            PontoDescarte pontoDescarte = dao.Buscar<PontoDescarte>(p => p.Alertas.Contains(alerta)).FirstOrDefault();
            return pontoDescarte;
        }*/
    }
}
