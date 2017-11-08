using BusinessLayer.Dao;
using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace ServiceLayer.Controllers
{
    public class ResiduoController : ApiController
    {
        [HttpGet]
        [ActionName("SalvarResiduo")]
        public int Inserir([FromUri]Residuo residuo, [FromUri]int[] id_fotos)
        {
            if(residuo != null)
            {
                residuo.Categoria = new Categoria();
                if (id_fotos.Length > 0)
                {
                    foreach(int id_foto in id_fotos)
                    {
                        SqlServerDao fotodao = new SqlServerDao();
                        Foto foto = fotodao.BuscarPorId<Foto>(id_foto);
                        if (foto != null)
                        {
                            residuo.Fotos.Add(foto);
                        }
                    }
                }
                ResiduoDao dao = new ResiduoDao();
                return dao.Inserir(residuo);
            }
            return 0;
        }

        [HttpGet]
        [ActionName("ListarResiduos")]
        public string ListarResiduos([FromUri] int ultimoId)
        {

            SqlServerDao dao = new SqlServerDao();
                List<Residuo> residuos;
                if (ultimoId > 0)
                {
                    residuos = dao.BuscarComPaginacao<Residuo>(p => p.Id >0, 3, ultimoId);
                }
                else
                {
                   residuos = (List<Residuo>)dao.ListarTodos<Residuo>().Take(3).ToList();
                }

                if(residuos != null)
                {
                    return JsonConvert.SerializeObject(residuos);
                }
                else
                {
                    return "";
                }
        }
    }
}
