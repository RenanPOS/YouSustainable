using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class RotaColetaDao
    {
        public bool Inserir(RotaColeta rotaColeta)
        {
            using (SqlServerDao dao = new SqlServerDao())
            {

               Area area = dao.BuscarPorId<Area>(rotaColeta.AreaId);

                rotaColeta.Area = area;

                dao.Inserir<RotaColeta>(rotaColeta);

                var test = dao.Buscar<RotaColeta>(p => p.Nome.Equals(rotaColeta.Nome));

                if (test != null)
                {
                    return true;
                }
            }

            return false;
        }

        public List<RotaColeta> ListarTodas(int id)
        {
            using (SqlServerDao dao = new SqlServerDao()) {

                List<RotaColeta> rotas = dao.ListarTodos<RotaColeta>();
                List<RotaColeta> rotasArea = new List<RotaColeta>();
                foreach(RotaColeta rota in rotas){
                    if(rota.AreaId == id)
                    {
                        rotasArea.Add(rota);
                    }
                }
                return rotasArea;

            }
        }
    }
}
