using System;
using BusinessLayer.Model;
using BusinessLayer.Dao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestLayer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InserirTeste()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                Usuario usuario = new Usuario()
                {
                    Nome = "User test",
                    Email = "user_test@gmail.com",
                    Senha = "usertest",
                    RaioBusca = 100,
                    Pontos = 0
                };

                dao.Inserir<Usuario>(usuario);

                usuario.Nome = "User removido";
                usuario.Email = "user_remove@gmail.com";

                dao.Inserir<Usuario>(usuario);

                List<Usuario> usuarios = dao.ListarTodos<Usuario>();
                dao.Dispose();

                Assert.IsNotNull(usuarios);
            }
        }


        [TestMethod]
        public void DeletarTeste()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                Usuario usuario = new Usuario()
                {
                    Nome = "User removido"
                };

                List<Usuario> usuarios = dao.ListarTodos<Usuario>();
                foreach (Usuario user in usuarios)
                {
                    if (user.Nome.Equals(usuario.Nome))
                    {
                        dao.Excluir<Usuario>(user);
                    }
                }

                List<Usuario> lista = dao.ListarTodos<Usuario>();
                Assert.IsNotNull(lista);
            }
        }

        [TestMethod]
        public void LogarTeste()
        {
            using(UsuarioDao dao = new UsuarioDao())
            {
                Usuario usuario = new Usuario()
                {
                    Email = "user_test@gmail.com",
                    Senha = "usertest"
                };

                var login = dao.EfetuarLogin(usuario.Email, usuario.Senha);

                Assert.IsTrue(login);
            }
        }
    }
}
