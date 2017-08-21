using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class SqlServerDao : DataLayer.Dao.SqlServerDao
    {
        protected DbSet<Usuario> DbSetUsuario { get; set; }
    }
}
