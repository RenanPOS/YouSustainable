using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dao
{
    public class CategoriaDao
    {
        public List<Categoria> ListarTodas()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                List<Categoria> categorias = dao.ListarTodos<Categoria>();
                return categorias;
            }
        }

        public List<Origem> ListarOrigem(Categoria categoria)
        {
            using (SqlServerDao dao = new SqlServerDao())
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
            using (SqlServerDao dao = new SqlServerDao())
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
            using (SqlServerDao dao = new SqlServerDao())
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
            using (SqlServerDao dao = new SqlServerDao())
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
        public int InserirCategoria(Categoria categoria)
        {
            SqlServerDao dao_generico = new SqlServerDao();
            List<Origem> origens =  new List<Origem>();
            foreach(Origem origem in categoria.Origens)
            {
                origens.Add(dao_generico.BuscarPorId<Origem>(origem.Id));
            }
            categoria.Origens = origens;

            List<ComposicaoQuimica> composicoesQuimicas = new List<ComposicaoQuimica>();
            foreach (ComposicaoQuimica composicao in categoria.ComposicoesQuimica)
            {
                composicoesQuimicas.Add(dao_generico.BuscarPorId<ComposicaoQuimica>(composicao.Id));
            }
            categoria.ComposicoesQuimica = composicoesQuimicas;

            List<Periculosidade> periculosidades = new List<Periculosidade>();
            foreach (Periculosidade periculosidade in categoria.Periculosidades)
            {
                periculosidades.Add(dao_generico.BuscarPorId<Periculosidade>(periculosidade.Id));
            }
            categoria.Periculosidades = periculosidades;

            List<Tipo> tipos = new List<Tipo>();
            foreach (Tipo tipo in categoria.Tipos)
            {
                tipos.Add(dao_generico.BuscarPorId<Tipo>(tipo.Id));
            }
            categoria.Tipos = tipos;
            dao_generico.Inserir(categoria);
            return categoria.Id;
        }
    }
}
