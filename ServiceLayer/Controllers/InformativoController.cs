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
    }
}
