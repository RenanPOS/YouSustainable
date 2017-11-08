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
    public class AreaAdministrativaController : ApiController
    {
        [HttpGet]
        [ActionName("CadastrarArea")]
        public bool Inserir([FromUri]Area area)
        {

            AreaDao dao = new AreaDao();
            return dao.Inserir(area);

        }

        [HttpGet]
        [ActionName("ListarAreas")]
        public String ListarAreas()
        {
            List<Area> areas;
            AreaDao dao = new AreaDao();

            areas = dao.ListarTodas();

            return JsonConvert.SerializeObject(areas);

        }
    }
}
