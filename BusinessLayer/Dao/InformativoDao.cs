using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class InformativoDao
    {
        public Informativo BuscarInformativoPorTitulo(string titulo)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                Informativo informativo = dao.Buscar<Informativo>(p => p.Titulo == titulo).FirstOrDefault();
                return informativo;
            }
        }

        public Informativo InformativoAleatorio()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                Informativo informativo = (Informativo)dao.Buscar<Informativo>(p => p.Id > 0).FirstOrDefault();
                return informativo;
            }
        }

        public void Inserir(Informativo informativo)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                //Informativo Informativo = dao.Buscar<Informativo>(p => p.Nome.Equals(nome)).FirstOrDefault();
                dao.Inserir(informativo);
            }
        }
    }
}
