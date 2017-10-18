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
    public class ResiduoController : ApiController
    {
        [HttpGet]
        [ActionName("SalvarResiduo")]
        public int Inserir([FromUri]Residuo residuo, [FromUri]int[] id_fotos, [FromUri]int[] id_origens, [FromUri]int[] id_periculosidades, [FromUri]int[] id_tipos, [FromUri]int[] id_composicoes)
        {
            if(residuo != null)
            {
                if(id_fotos.Length > 0 && false)
                {
                    foreach(int id_foto in id_fotos)
                    {
                        Foto foto = new Foto();
                        foto.Id = id_foto;
                        residuo.Fotos.Add(foto);
                    }
                }
                if (id_origens.Length > 0)
                {
                    foreach (int id_origem in id_origens)
                    {
                        Origem origem = new Origem();
                        origem.Id = id_origem;
                        residuo.Categoria.Origens.Add(origem);
                    }
                }
                if (id_periculosidades.Length > 0)
                {
                    foreach (int id_periculosidade in id_periculosidades)
                    {
                        Periculosidade periculosidade = new Periculosidade();
                        periculosidade.Id = id_periculosidade;
                        residuo.Categoria.Periculosidades.Add(periculosidade);
                    }
                }
                if (id_tipos.Length > 0)
                {
                    foreach (int id_tipo in id_tipos)
                    {
                        Tipo tipo = new Tipo();
                        tipo.Id = id_tipo;
                        residuo.Categoria.Tipos.Add(tipo);
                    }
                }
                if (id_composicoes.Length > 0)
                {
                    foreach (int id_composicao in id_composicoes)
                    {
                        ComposicaoQuimica composicao = new ComposicaoQuimica();
                        composicao.Id = id_composicao;
                        residuo.Categoria.ComposicoesQuimica.Add(composicao);
                    }
                }
                ResiduoDao dao = new ResiduoDao();
                return dao.Inserir(residuo);
            }
            return 0;
        }
    }
}
