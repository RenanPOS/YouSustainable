using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class DenunciaDao
    {
        public void Inserir(Denuncia denuncia)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir(denuncia);
            }
        }
    }
}
