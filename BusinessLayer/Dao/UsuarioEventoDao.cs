using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class UsuarioEventoDao : SqlServerDao
    {
        public List<Usuario> BuscarInscritos(string nome)
        {
            Evento evento;
            using (EventoDao dao = new EventoDao())
            {
                evento = dao.BuscarEventoNome(nome);
            }
            using (SqlServerDao dao = new SqlServerDao())
            {
                List<Usuario> test = dao.ListarTodos<Usuario>();
                List<Usuario> usuarios = new List<Usuario>();

                foreach(Usuario user in test)
                {
                    //comparar id de evento na tabela UsuarioEvento e adicionar o usuario no List
                    usuarios.Add(user);
                }

                return usuarios;
            }
        }
    }
}
