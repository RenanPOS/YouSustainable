using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer.Testes
{
    [TestClass]
    public class AdministradorTest
    {
        [TestMethod]
        public void InserirAdministrador()
        {
            Administrador administrador = new Administrador()
            {
                Nome = "Admin",
                Email = "adm_email@gmail.com",
                Senha = "admsenha",
                RaioBusca = 200,
                Pontos = 0
            };

            using (SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Administrador>(administrador);

                var test = dao.ListarTodos<Administrador>();
                Assert.IsNotNull(test);
            }
        }

        [TestMethod]
        public void AdmInformativo()
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                Administrador adm = dao.BuscarPorId<Administrador>(3);
                Informativo informativo = new Informativo()
                {
                    Titulo = "Memória Ram",
                    Descricao = "Memória ram não deve ser descartada como um metal comúm, procure um local apropriado"
                };
                informativo.Administradores.Add(adm);
                dao.Inserir<Informativo>(informativo);

                var test = dao.ListarTodos<Informativo>();

                Assert.IsNotNull(test);
            }
        }
    }
}
