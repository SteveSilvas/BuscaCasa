using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class ProprietarioConfiguration : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.ToTable("Proprietario");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(e => e.UsuarioID)
               .HasColumnName("usuario")
               .HasColumnType("bigint")
               .IsRequired();

            builder.HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioID)
                .HasConstraintName("Usuario_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasMany(p => p.Propriedades)
                .WithOne(pr => pr.Proprietario)
                .HasForeignKey(pr => pr.ProprietarioID)
                .HasConstraintName("Proprietario_Propriedade_fkey")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}