using System;
using System.Collections.Generic;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer
{
    [TestClass]
    public class EventoTest
    {
        [TestMethod]
        public void Inserir()
        {
            Evento evento = new Evento()
            {
                Nome = "Evento 1",
                Descricao = "Evento Test",
                Cidade = "Curitiba",
                Bairro = "Centro",
                Estado = "PR",
                Numero = 250,
                Rua = "João Negrão",
                URLFoto = "foto"
            };

            using (SqlServerDao dao = new SqlServerDao())
            {
                dao.Inserir<Evento>(evento);

                evento.Nome = "Evento Dois";
                dao.Inserir<Evento>(evento);

                List<Evento> eventos = dao.ListarTodos<Evento>();
                dao.Dispose();
                Assert.IsNotNull(eventos);
            }

        }

        [TestMethod]
        public void Excluir()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                var nome = "Evento Dois";

                dao.Excluir<Evento>(p => p.Nome.Equals(nome));

                var eventos = dao.ListarTodos<Evento>();
                Assert.IsNotNull(eventos);
            }
        }

        [TestMethod]
        public void EventoUsuarioTest()
        {
            using (SqlServerDao dao = new SqlServerDao())
            {
                var user = dao.BuscarPorId<Usuario>(1);

                Evento evento = new Evento()
                {
                    Nome = "Evento 3",
                    Descricao = "Evento Test",
                    Cidade = "Curitiba",
                    Bairro = "Centro",
                    Estado = "PR",
                    Numero = 250,
                    Rua = "João Negrão",
                    URLFoto = "foto"
                };

                evento.Inscritos.Add(user);

                dao.Inserir<Evento>(evento);


            }
        }

        [TestMethod]
        public void BuscarInscrito()
        {
            UsuarioEventoDao dao = new UsuarioEventoDao();
                var inscritos = dao.BuscarInscritos("Evento 3");

                Assert.AreNotEqual(inscritos.Count, 0);
        }

    }
}
