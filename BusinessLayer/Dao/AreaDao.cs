using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class AreaDao
    {
        public bool Inserir(Area area)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Area>(area);

                var test = dao.Buscar<Area>(p => p.Nome.Equals(area.Nome));
                if (test != null)
                    return true;
                return false;
            }

        }

        public List<Area> ListarTodas()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                List<Area> areas = dao.ListarTodos<Area>();
                return areas;
            }
        }
    }
}
