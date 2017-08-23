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
       [ActionName("EfetuarLogin")]
       public bool EfetuarLogin([FromUri]Usuario usuario) 
        {
            using (UsuarioDao dao = new UsuarioDao())
            { 
                var login = dao.EfetuarLogin(usuario.Email, usuario.Senha);
                if (login)
                    return true;
                return false;
            }
        }

        [HttpGet]
        [ActionName("CadastrarUsuario")]
        public string CadastrarUsuario([FromUri]Usuario usuario)
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
