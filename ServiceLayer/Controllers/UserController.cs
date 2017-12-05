using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Newtonsoft.Json;

namespace ServiceLayer.Controllers
{
    public class UserController : ApiController
    {
       [HttpGet]
       [ActionName("EfetuarLogin")]
       public string EfetuarLogin([FromUri]Usuario usuario) 
        {
            using (UsuarioDao dao = new UsuarioDao())
            { 
                var login = dao.EfetuarLogin(usuario.Email, usuario.Senha);
                if (login != null)
                    return JsonConvert.SerializeObject(login);
                return "";
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

        [HttpGet]
        [ActionName("CheckarAdm")]
        public bool CheckarAdm(string email)
        {
            UsuarioDao dao = new UsuarioDao();
            return dao.CheckarAdm(email);
        }

        /*[HttpGet]
        [ActionName("ListarUsuarioArea")]
        public bool ListarUsuarioArea(int id)
        {
            UsuarioDao dao = new UsuarioDao();
            return dao.ListarTodos(id);
        }*/
    }
}
