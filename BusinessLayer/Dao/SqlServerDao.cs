using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;
using DataLayer.Model;
using BusinessLayer.Migrations;

namespace BusinessLayer.Dao
{
    public class SqlServerDao : DataLayer.Dao.SqlServerDao
    {
        static SqlServerDao()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqlServerDao, Configuration>());
        }
        public DbSet<Acao> DbSetAcao { get; set; }
        public DbSet<Administrador> DbSetAdministrador { get; set; }
        public DbSet<Alerta> DbSetAlerta { get; set; }
        public DbSet<Categoria> DbSetCategoria { get; set; }
        public DbSet<ComposicaoQuimica> DbSetComposicaoQuimica { get; set; }
        public DbSet<DataRota> DbSetDataRota { get; set; }
        public DbSet<Foto> DbSetFoto { get; set; }
        public DbSet<Localizacao> DbSetLocalizacao { get; set; }
        public DbSet<Modulo> DbSetModulo { get; set; }
        public DbSet<Origem> DbSetOrigem { get; set; }
        public DbSet<Periculosidade> DbSetPericulosidade { get; set; }
        public DbSet<Periodo> DbSetPeriodo { get; set; }
        public DbSet<PontoDescarte> DbSetPontoDescarte { get; set; }
        public DbSet<Privilegio> DbSetPrivilegio { get; set; }
        public DbSet<RotaColeta> DbSetRotaColeta { get; set; }
        public DbSet<Tipo> DbSetTipo { get; set; }
        public DbSet<Usuario> DbSetUsuario { get; set; }
        public DbSet<Area> DbSetArea { get; set; }
        public DbSet<Evento> DbSetEvento { get; set; }
        public DbSet<ZonaVerde> DbSetZonaVerde { get; set; }
        public DbSet<Residuo> DbSetResiduo { get; set; }
        public DbSet<Denuncia> DbSetDenuncia { get; set; }
        public DbSet<Informativo> DbSetInformativo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.Configuration.LazyLoadingEnabled = false;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Acao>()
                .HasRequired(t => t.Usuario);
            modelBuilder.Entity<Localizacao>()
                .HasOptional(l => l.ZonaVerde)
                .WithRequired(z => z.Localizacao);
            /*modelBuilder.Entity<Privilegio>()
                .HasRequired(t => t.Modulo);*/
            modelBuilder.Entity<DataRota>()
                .HasRequired(t => t.RotaColeta);
            modelBuilder.Entity<Usuario>()
                .HasMany<Evento>(u => u.Eventos)
                .WithMany(e => e.Inscritos)
                .Map(ue =>
                    {
                        ue.MapLeftKey("UsuarioId");
                        ue.MapRightKey("EventoId");
                        ue.ToTable("UsuarioEvento");
                    });
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Administrador>().ToTable("Administrador");
            modelBuilder.Entity<Categoria>()
                .HasMany<Origem>(s => s.Origens)
                .WithMany(c => c.Categorias)
                .Map(cs =>
                {
                    cs.MapLeftKey("Categoria.Id");
                    cs.MapRightKey("Origem.Id");
                    cs.ToTable("OrigemCategoria");
                });
        }
    }
}
