using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class TipoUsuarioConfiguration : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.ToTable("Tipo_Usuario");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID)
                .HasColumnName("id");

            builder.Property(s => s.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany(tpu => tpu.Usuarios)
                .WithOne(u => u.TipoUsuario)
                .HasForeignKey(u => u.TipoUsuarioID)
                .HasConstraintName("Tipo_Usuario_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}