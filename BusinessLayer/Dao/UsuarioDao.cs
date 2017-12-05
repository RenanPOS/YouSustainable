using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Dao
{
    public class UsuarioDao : SqlServerDao
    {
        public Usuario EfetuarLogin(string email, string senha)
        {
            using(SqlServerDao dao = new UsuarioDao())
            {
                var login = dao.Buscar<Usuario>(p => p.Email.Equals(email)).FirstOrDefault();
                if(login == null)
                {
                    return null;
                }
                else
                {
                    if (login.Senha.Equals(senha))
                    {
                        return login;
                    }
                }
            }

            return null;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            using(SqlServerDao dao = new UsuarioDao())
            {
                Usuario user = new Usuario()
                {
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha
                };

                dao.Inserir<Usuario>(user);
            }
        }

        public bool CheckarAdm(string email)
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                Usuario user = dao.Buscar<Usuario>(p => p.Email.Equals(email)).FirstOrDefault();
                Administrador adm = dao.BuscarPorId<Administrador>(user.Id);
                if(adm == null)
                {
                    return false;
                }
                return true;
            }
        }

        /*public List<Usuario> ListarTodos(int id)
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                List<Usuario> users = dao.ListarTodos<Usuario>();
                List<Privilegio> privilegios = new List<Privilegio>();
                List<Usuario> userAreas = new List<Usuario>();
                foreach (Usuario user in users)
                {
                    privilegios = dao.Buscar<Privilegio>(p => p.Usuario.Equals(user));
                }
         
                foreach(Privilegio privilegio in privilegios){
                    if(id == privilegio.Area.Id)
                    {
                        
                    }
                }
            }
        }*/
    }
}
