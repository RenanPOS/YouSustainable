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
    public class ZonaVerdeController : ApiController
    {
        [HttpGet]
        [ActionName("CadastrarZonaVerde")]
        public bool Inserir([FromUri]ZonaVerde zonaVerde)
        {
            ZonaVerdeDao dao = new ZonaVerdeDao();
            var test = dao.Inserir(zonaVerde);

            return test;
        }

        [HttpGet]
        [ActionName("ListarZonasVerdes")]
        public String ListarZonasVerdes()
        {
            List<ZonaVerde> zonasVerdes;
            ZonaVerdeDao dao = new ZonaVerdeDao();

            zonasVerdes = dao.BuscarZonasVerdes();
                
            return JsonConvert.SerializeObject(zonasVerdes);
            
        }

    }
}
