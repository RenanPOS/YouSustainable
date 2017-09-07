using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;
using DataLayer.Model;

namespace BusinessLayer.Dao
{
    public class SqlServerDao : DataLayer.Dao.SqlServerDao
    {
        protected DbSet<Usuario> DbSetUsuario { get; set; }
        protected DbSet<Area> DbSetArea { get; set; }
        protected DbSet<Evento> DbSetEvento { get; set; }
        protected DbSet<ZonaVerde> DbSetZonaVerde { get; set; }
        protected DbSet<Residuo> DbSetResiduo { get; set; }
        protected DbSet<Denuncia> DbSetDenuncia { get; set; }
        protected DbSet<Informativo> DbSetInformativo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Base>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Acao>()
                .HasRequired(t => t.Usuario);
            modelBuilder.Entity<ZonaVerde>()
                .HasRequired(t => t.Localizacao);
            modelBuilder.Entity<Privilegio>()
                .HasRequired(t => t.Modulo);
            modelBuilder.Entity<DataRota>()
                .HasRequired(t => t.RotaColeta);
        }
    }
}
