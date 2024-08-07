using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class StatusUsuarioConfiguration : IEntityTypeConfiguration<StatusUsuario>
    {
        public void Configure(EntityTypeBuilder<StatusUsuario> builder)
        {
            builder.ToTable("Status_Usuario");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID)
                .HasColumnName("id");

            builder.Property(s => s.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
