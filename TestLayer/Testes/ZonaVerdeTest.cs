using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer.Testes
{
    [TestClass]
    public class ZonaVerdeTest
    {
        [TestMethod]
        public void InserirZonaVerde()
        {
            Localizacao localizacao = new Localizacao()
            {
                Latitude = "25º 25' 40'' N",
                Longitude = "49º 16' 23'' W",
            };

            ZonaVerde zonaVerde = new ZonaVerde()
            {
                Nome = "Zona verde teste",
                Descricao = "Zona verde criada para teste",
                Localizacao = localizacao
            };

            using(SqlServerDao dao = new SqlServerDao())
            {
                //dao.Inserir<Localizacao>(localizacao);

                //zonaVerde.Localizacao = dao.BuscarPorId<Localizacao>(2);
                localizacao.ZonaVerde = zonaVerde;

                dao.Inserir<ZonaVerde>(zonaVerde);

                var test = dao.ListarTodos<ZonaVerde>();

                Assert.AreNotEqual(test.Count, 0);
            }
        }
    }
}
