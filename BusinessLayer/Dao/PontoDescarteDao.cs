using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class PontoDescarteDao
    {
        public bool Inserir(PontoDescarte ponto)
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Localizacao>(ponto.Localizacao);
                dao.Inserir<PontoDescarte>(ponto);

                var test = dao.Buscar<PontoDescarte>(p => p.Localizacao.Latitude.Equals(ponto.Localizacao.Latitude));
                if (test != null)
                    return true;
            }

            return false;
        }

        public List<PontoDescarte> ListarTodos()
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                var lista = dao.ListarTodos<PontoDescarte>();
                return lista;
            }
        }

        public List<PontoDescarte> ListarTodos(int id)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                var lista = dao.ListarTodos<PontoDescarte>();
                List<PontoDescarte> pontos = new List<PontoDescarte>();
                foreach (PontoDescarte ponto in lista)
                {
                    if(ponto.Area.Id == 0)
                    {
                        ///tratar os sem ids de area
                    }
                    if (ponto.Area.Id == id)
                    {
                        pontos.Add(ponto);
                    }
                }
                return pontos;
            }
        }

        public PontoDescarte BuscarPorId(int id)
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                return dao.BuscarPorId<PontoDescarte>(id);
            }
        }
    }
}
