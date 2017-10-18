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
        public bool Inserir([FromUri]ZonaVerde zonaVerde, [FromUri]Localizacao localizacao)
        {
            zonaVerde.Localizacao = localizacao;
            
            ZonaVerdeDao zonaVerdeDao = new ZonaVerdeDao();
            var test = zonaVerdeDao.Inserir(zonaVerde);

            return true;
        }

        [HttpGet]
        [ActionName("ListarZonasVerdes")]
        public String ListarZonasVerdes()
        {
            List<ZonaVerde> zonasVerdes;
            ZonaVerdeDao dao = new ZonaVerdeDao();

            zonasVerdes = dao.ListarTodas();
                
            return JsonConvert.SerializeObject(zonasVerdes);
            
        }

    }
}
