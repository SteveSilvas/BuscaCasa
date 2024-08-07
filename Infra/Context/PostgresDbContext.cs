using Domain.Entities;
using Infra.DbConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Authenticator.Context
{
    public class PostgresDbContext : DbContext
    {
        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }
        public DbSet<Imobiliaria> Imobiliarias { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Propriedade> Propriedades { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<StatusImovel> StatusImoveis { get; set; }
        public DbSet<StatusUsuario> StatusUsuarios { get; set; }
        public DbSet<StatusVisita> StatusVisitas { get; set; }
        public DbSet<TipoComercializacao> TiposComercializacoes { get; set; }
        public DbSet<TipoComercializacaoImovel> TiposComercializacoesImoveis { get; set; }
        public DbSet<TipoConstrucaoImovel> TiposConstrucoesImoveis { get; set; }
        public DbSet<TipoUsoImovel> TiposUsosImoveis { get; set; }
        public DbSet<TipoUsuario> TiposUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CorretorConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new FavoritoConfiguration());
            modelBuilder.ApplyConfiguration(new ImobiliariaConfiguration());
            modelBuilder.ApplyConfiguration(new ImovelConfiguration());
            modelBuilder.ApplyConfiguration(new MunicipioConfiguration());
            modelBuilder.ApplyConfiguration(new PropriedadeConfiguration());
            modelBuilder.ApplyConfiguration(new ProprietarioConfiguration());
            modelBuilder.ApplyConfiguration(new RegiaoConfiguration());
            modelBuilder.ApplyConfiguration(new StatusImovelConfiguration());
            modelBuilder.ApplyConfiguration(new StatusUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new StatusVisitaConfiguration());
            modelBuilder.ApplyConfiguration(new TipoComercializacaoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoComercializacaoImovelConfiguration());
            modelBuilder.ApplyConfiguration(new TipoConstrucaoImovelConfiguration());
            modelBuilder.ApplyConfiguration(new TipoUsoImovelConfiguration());
            modelBuilder.ApplyConfiguration(new TipoUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new VisitaConfiguration());
        }
        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    return base.SaveChangesAsync(cancellationToken);
        //}
    }
}
