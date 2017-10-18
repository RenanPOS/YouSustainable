using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class CategoriaDao : SqlServerDao
    {
        public List<Categoria> ListarTodas(string categoria)
        {
            using (SqlServerDao dao = new CategoriaDao())
            {
                List<Categoria> categorias = dao.ListarTodos<Categoria>();
                return categorias;
            }
        }

        public List<Origem> ListarOrigem(Categoria categoria)
        {
            using (SqlServerDao dao = new CategoriaDao())
            {
                List<Origem> origens;
                if (categoria.Id != 0)
                {
                    origens = dao.Buscar<Origem>(o => o.Categorias.Where(c => c.Id == categoria.Id).FirstOrDefault()!=null);
                }
                else
                {
                    origens = dao.ListarTodos<Origem>();
                }
                return origens;
            }
        }
        public List<Periculosidade> ListarPericulosidade(Categoria categoria)
        {
            using (SqlServerDao dao = new CategoriaDao())
            {
                List<Periculosidade> periculosidades;
                if (categoria.Id != 0)
                {
                    periculosidades = dao.Buscar<Periculosidade>(o => o.Categorias.Where(c => c.Id == categoria.Id) != null);
                }
                else
                {
                    periculosidades = dao.ListarTodos<Periculosidade>();
                }
                return periculosidades;
            }
        }

        public List<Tipo> ListarTipo(Categoria categoria)
        {
            using (SqlServerDao dao = new CategoriaDao())
            {
                List<Tipo> tipos;
                if (categoria.Id != 0)
                {
                    tipos = dao.Buscar<Tipo>(o => o.Categorias.Where(c => c.Id == categoria.Id) != null);
                }
                else
                {
                    tipos = dao.ListarTodos<Tipo>();
                }
                return tipos;
            }
        }

        public List<ComposicaoQuimica> ListarComposicaoQuimica(Categoria categoria)
        {
            using (SqlServerDao dao = new CategoriaDao())
            {
                List<ComposicaoQuimica> compQuimica;
                if (categoria.Id != 0)
                {
                    compQuimica = dao.Buscar<ComposicaoQuimica>(o => o.Categorias.Where(c => c.Id == categoria.Id) != null);
                }
                else
                {
                    compQuimica = dao.ListarTodos<ComposicaoQuimica>();
                }
                return compQuimica;
            }
        }
    }
}
