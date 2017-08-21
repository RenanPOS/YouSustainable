using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Dao;
using BusinessLayer.Model;

namespace ServiceLayer.Controllers
{
    public class UserController : ApiController
    {
       [HttpGet]
       public string EfetuarLogin(string email, string senha) 
        {
            using (UsuarioDao dao = new UsuarioDao())
            {
                Usuario usuario = new Usuario()
                {
                    Email = "user_test@gmail.com",
                    Senha = "usertest"
                };

                var login = dao.EfetuarLogin(usuario.Email, usuario.Senha);
                if (login)
                    return "Nice :)";
                return "Bad :(";
            }
        }

        [HttpGet]
        public string CadastrarUsuario(Usuario usuario)
        {
            using (UsuarioDao dao = new UsuarioDao())
            {
                try
                {
                    dao.CadastrarUsuario(usuario);
                    return "Cadastro efetuado";
                }
                catch(Exception e)
                {
                    return "Ocorreu algum problema, tente novamente em alguns minutos";
                }
            }
        }
    }
}
