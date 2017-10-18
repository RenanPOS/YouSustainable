using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer.Testes
{
    [TestClass]
    public class AlertaTest
    {
        [TestMethod]
        public void Inserir()
        {
            AlertaDao dao = new AlertaDao();


            Alerta alerta = new Alerta()
            {
                Descricao = "Cheia",
                DataCriacao = DateTime.Now,
                DataAtualizacao = DateTime.Now

            };

            using(SqlServerDao sqlDao = new SqlServerDao())
            {
                var ponto = sqlDao.BuscarPorId<PontoDescarte>(5);
                ponto.Alertas.Add(alerta);
                ponto.Estado = "Inutilizável";
                sqlDao.Atualizar<PontoDescarte>(ponto);
            }
          
            var list = dao.ListarTodos();
            Assert.AreNotEqual(0, list.Count);
        }
    }
}
