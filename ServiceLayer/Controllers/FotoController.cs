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
    public class FotoController : ApiController
    {
        [HttpGet]
        [ActionName("SalvarFoto")]
        public int Inserir([FromUri]Foto foto)
        {
            if(foto!= null)
            {
                using(FotoDao dao = new FotoDao())
                {
                    try
                    {
                        dao.Inserir(foto);
                        return foto.Id;
                    }catch(Exception e)
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }
    }
}
