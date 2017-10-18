using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class FotoDao : SqlServerDao
    {
        public bool Inserir(Foto foto)
        {
            if( foto != null)
            {
                using(SqlServerDao dao = new FotoDao())
                {
                    dao.Inserir(foto);
                    Console.WriteLine(foto.Id);
                    return true;
                }
            }
            return false;
        }
    }
}
