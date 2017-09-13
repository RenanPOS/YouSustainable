using System;
using BusinessLayer.Dao;
using BusinessLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLayer.Testes
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void InserirArea()
        {
            using(SqlServerDao dao = new SqlServerDao())
            {
                Usuario usuario = dao.BuscarPorId<Usuario>(1);

                Modulo modulo = new Modulo()
                {
                    Nome = "Administrador"
                };

                Privilegio privilegio = new Privilegio()
                {
                    Nivel = 'A',
                    Modulo = modulo,
                    Usuario = usuario
                };
                modulo.Privilegios.Add(privilegio);

                dao.Inserir<Modulo>(modulo);

                Area area = new Area()
                {
                    Nome = "Area teste",
                    Descricao = "Area usada no teste unitário, para incluir privilégios"
                };

                area.Privilegios.Add(privilegio);

                dao.Inserir<Area>(area);

                var test = dao.ListarTodos<Area>();

                Assert.AreNotEqual(test.Count, 0);
                
            }
        }
    }
}
