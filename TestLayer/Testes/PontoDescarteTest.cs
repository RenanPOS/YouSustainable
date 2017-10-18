using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer.Testes
{
    [TestClass]
    public class PontoDescarteTest
    {
        [TestMethod]
        public void Inserir()
        {
            PontoDescarteDao dao = new PontoDescarteDao();
            PontoDescarte ponto = new PontoDescarte()
            {
                EhPArticular = false,
                Estado = "Cheia"
            };

            dao.Inserir(ponto);

            var test = dao.ListarTodos();
            Assert.AreNotEqual(test.Count, 0);
        }
    }
}
