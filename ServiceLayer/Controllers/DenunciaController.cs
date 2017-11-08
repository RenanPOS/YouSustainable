using BusinessLayer.Dao;
using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceLayer.Controllers
{
    public class DenunciaController : ApiController
    {
        // GET: api/Denuncia
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Denuncia/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [ActionName("Denunciar")]
        public int Denunciar([FromBody]Denuncia denuncia)
        {
            DenunciaDao dao = new DenunciaDao();
                if(denuncia != null)
                {
                    dao.Inserir(denuncia);
                    return denuncia.Id;
                }
            return 0;
        }

        // PUT: api/Denuncia/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Denuncia/5
        public void Delete(int id)
        {
        }
    }
}
