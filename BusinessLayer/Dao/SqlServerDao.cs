using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;
using DataLayer.Model;

namespace BusinessLayer.Dao
{
    public class SqlServerDao : DataLayer.Dao.SqlServerDao
    {
        protected DbSet<Acao> DbSetAcao { get; set; }
        protected DbSet<Administrador> DbSetAdministrador { get; set; }
        protected DbSet<Alerta> DbSetAlerta { get; set; }
        protected DbSet<Categoria> DbSetCategoria { get; set; }
        protected DbSet<ComposicaoQuimica> DbSetComposicaoQuimica { get; set; }
        protected DbSet<DataRota> DbSetDataRota { get; set; }
        protected DbSet<Foto> DbSetFoto { get; set; }
        protected DbSet<Localizacao> DbSetLocalizacao { get; set; }
        protected DbSet<Modulo> DbSetModulo { get; set; }
        protected DbSet<Origem> DbSetOrigem { get; set; }
        protected DbSet<Periculosidade> DbSetPericulosidade { get; set; }
        protected DbSet<Periodo> DbSetPeriodo { get; set; }
        protected DbSet<PontoDescarte> DbSetPontoDescarte { get; set; }
        protected DbSet<Privilegio> DbSetPrivilegio { get; set; }
        protected DbSet<RotaColeta> DbSetRotaColeta { get; set; }
        protected DbSet<Tipo> DbSetTipo { get; set; }
        protected DbSet<Usuario> DbSetUsuario { get; set; }
        protected DbSet<Area> DbSetArea { get; set; }
        protected DbSet<Evento> DbSetEvento { get; set; }
        protected DbSet<ZonaVerde> DbSetZonaVerde { get; set; }
        protected DbSet<Residuo> DbSetResiduo { get; set; }
        protected DbSet<Denuncia> DbSetDenuncia { get; set; }
        protected DbSet<Informativo> DbSetInformativo { get; set; }

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
           /* modelBuilder.Entity<RotaColeta>()
                .HasRequired<Area>(r => r.Area);*/
        }
    }
}
