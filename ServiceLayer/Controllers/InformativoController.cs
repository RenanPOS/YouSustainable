using BusinessLayer.Dao;
using BusinessLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceLayer.Controllers
{
    public class InformativoController : ApiController
    {
        [HttpGet]
        [ActionName("InformativoAleatorio")]
        public string InformativoAleatorio()
        {
            Informativo informativo;
            using (InformativoDao dao = new InformativoDao())
            {
                informativo = dao.InformativoAleatorio();
                if (informativo != null)
                {
                    return JsonConvert.SerializeObject(informativo);
                }
                else
                {
                    return "";
                }
            }
        }

        [HttpGet]
        [ActionName("ListarInformativos")]
        public string ListarInformativos()
        {
            InformativoDao dao = new InformativoDao();
            List<Informativo> lista = dao.ListarTodos();
            return JsonConvert.SerializeObject(lista);
        }

        [HttpGet]
        [ActionName("CadastrarInformativo")]
        public bool Inserir([FromUri]Informativo informativo)
        {
            InformativoDao dao = new InformativoDao();
            return dao.Inserir(informativo);
        }
    }
}
