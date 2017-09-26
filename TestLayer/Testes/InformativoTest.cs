using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer.Model;
using BusinessLayer.Dao;
using System.Collections.Generic;

namespace TestLayer.Testes
{
    [TestClass]
    public class InformativoTest
    {
        [TestMethod]
        public void Inserir()
        {
            Informativo informativo = new Informativo()
            {
                Titulo = "Guardanapo Engordurado!",
                Descricao = "Não se esqueça, guardanapos engordurados não são recicláveis!"
            };

            using (SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Informativo>(informativo);

                List<Informativo> informativos = dao.ListarTodos<Informativo>();
                dao.Dispose();
                Assert.IsNotNull(informativos);
            }

        }
    }
}
