using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer
{
    [TestClass]
    public class DenunciaTest
    {
        [TestMethod]
        public void DenunciarEvento()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                var usuario = dao.BuscarPorId<Usuario>(1);
                var evento = dao.BuscarPorId<Evento>(1);

                Denuncia denuncia = new Denuncia()
                {
                    Descricao = "Evento não é sobre sustentabilidade",
                    Estado = "Submetido",
                    Usuario = usuario,
                    Evento = evento
                };

                dao.Inserir<Denuncia>(denuncia);

                var test = dao.ListarTodos<Denuncia>();
                Assert.IsNotNull(test);
            }
        }
    }
}
