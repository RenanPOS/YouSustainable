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
                Nome = "Nome adm",
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
                    Titulo = "Informativo teste",
                    Descricao = "Informativo para teste, vai funcionar, e o relacionamento vai estar nice"
                };
                informativo.Administradores.Add(adm);
                dao.Inserir<Informativo>(informativo);

                var test = dao.ListarTodos<Informativo>();

                Assert.IsNotNull(test);
            }
        }
    }
}
