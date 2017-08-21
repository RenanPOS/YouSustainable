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
        public bool EfetuarLogin(string email, string senha)
        {
            using(SqlServerDao dao = new UsuarioDao())
            {
                var login = dao.Buscar<Usuario>(p => p.Email.Equals(email)).FirstOrDefault();
                if(login == null)
                {
                    return false;
                }
                else
                {
                    if (login.Senha.Equals(senha))
                    {
                        return true;
                    }
                }
            }

            return false;
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
    }
}
