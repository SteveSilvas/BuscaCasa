using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("id");

            builder.Property(m => m.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasOne(m => m.Estado)
                .WithMany(e => e.Municipios)
                .HasForeignKey(m => m.EstadoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}