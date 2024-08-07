using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");

            builder.HasKey(e => e.ID);

            builder.Property(e => e.ID)
                .HasColumnName("id");

        
            builder.Property(e => e.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(e => e.Sigla)
                .HasColumnName("sigla")
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.HasOne(e => e.Regiao)
                .WithMany(r => r.Estados)
                .HasForeignKey(e => e.RegiaoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.Municipios)
                .WithOne(m => m.Estado)
                .HasForeignKey(m => m.EstadoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}