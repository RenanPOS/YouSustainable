﻿using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class ResiduoDao : SqlServerDao
    {
        public int Inserir(Residuo residuo)
        {
            if(residuo != null)
            {
                using(SqlServerDao dao = new ResiduoDao())
                {
                    dao.Inserir(residuo);
                    return residuo.Id;
                }
            }
            return 0;
        }
    }
}
