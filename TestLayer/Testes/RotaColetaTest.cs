using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer.Testes
{
    [TestClass]
    public class RotaColetaTest
    {
        [TestMethod]
        public void Inserir()
        {
            RotaColeta rota = new RotaColeta()
            {
                Nome = "Rota de Sábado",
                Status = "Ativa"
            };

            RotaColetaDao dao = new RotaColetaDao();
            var test = dao.Inserir(rota);

            Assert.IsTrue(test);

        }
    }
}
