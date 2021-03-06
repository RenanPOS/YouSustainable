﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class ZonaVerdeDao
    {
        public bool Inserir(ZonaVerde zonaVerde)
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Localizacao>(zonaVerde.Localizacao);

                dao.Inserir<ZonaVerde>(zonaVerde);

                var test = dao.Buscar<ZonaVerde>(p => p.Nome.Equals(zonaVerde.Nome));

                if(test != null)
                {
                    return true;
                }

                return false;
            }
        }

        public List<ZonaVerde> BuscarZonasVerdes()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                List<ZonaVerde> zonasVerdes = dao.ListarTodos<ZonaVerde>();
                return zonasVerdes;
            }
        }

        public List<ZonaVerde> ListarTodas()
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                List<ZonaVerde> zonasVerdes = dao.ListarTodos<ZonaVerde>();
                return zonasVerdes;
            }
        }
    }
}
