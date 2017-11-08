namespace BusinessLayer.Migrations
{
    using BusinessLayer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusinessLayer.Dao.SqlServerDao>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BusinessLayer.Dao.SqlServerDao context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.DbSetOrigem.AddOrUpdate(
                p => p,
                new Origem { Descricao = "Domestica", Peso = 1},
                new Origem { Descricao = "Comercial", Peso = 1 },
                new Origem { Descricao = "Industrial", Peso = 1 },
                new Origem { Descricao = "Hospitalar", Peso = 1 }
                );
        }
    }
}
