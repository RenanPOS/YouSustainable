using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class InformativoDao : SqlServerDao
    {
        public Informativo BuscarInformativoPorTitulo(string titulo)
        {
            int qtde;

            using (SqlServerDao dao = new InformativoDao())
            {
                qtde = dao.ListarTodos<Informativo>().Count();
                Random rd = new Random();
                int aleatorio = rd.Next(1, qtde);
                Informativo informativo = dao.BuscarPorId<Informativo>(aleatorio);
                return informativo;
            }
            
        }

        public Informativo InformativoAleatorio()
        {
            using (SqlServerDao dao = new InformativoDao())
            {
                List<Informativo> informativos = dao.ListarTodos<Informativo>();
                int qtde = informativos.Count();
                Random rd = new Random();
                int aleatorio = rd.Next(1, qtde);
                return informativos[aleatorio];
            }
        }

        public bool Inserir(Informativo informativo)
        {
            using (SqlServerDao dao = new InformativoDao())
            {
                //Informativo Informativo = dao.Buscar<Informativo>(p => p.Nome.Equals(nome)).FirstOrDefault();
                dao.Inserir(informativo);
                var test = dao.Buscar<Informativo>(p => p.Titulo.Equals(informativo.Titulo));
                if (test != null)
                    return true;
                return false;
            }
        }

        public List<Informativo> ListarTodos()
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                return dao.ListarTodos<Informativo>();
            }
        }
    }
}
