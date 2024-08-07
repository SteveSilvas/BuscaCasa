using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class CorretorConfiguration : IEntityTypeConfiguration<Corretor>
    {
        public void Configure(EntityTypeBuilder<Corretor> builder)
        {
            builder.ToTable("Corretor");

            builder.HasKey(c => c.ID);

            builder.Property(c => c.ID)
                .HasColumnName("id");

            builder.Property(c => c.Sigla)
                .HasColumnName("sigla")
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(c => c.UsuarioID)
                .HasColumnName("usuario")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.UsuarioID)
                .HasConstraintName("Corretor_Usuario_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(c => c.ImobiliariaID)
                .HasColumnName("imobiliaria")
                .HasColumnType("bigint")
                .IsRequired(false);

            builder.HasOne(c => c.Imobiliaria)
                .WithMany()
                .HasForeignKey(c => c.ImobiliariaID)
                .HasConstraintName("Corretor_Imobiliaria_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasMany(c => c.Visitas)
                .WithOne(v => v.Corretor)
                .HasForeignKey(v => v.CorretorID)
                .HasConstraintName("Visita_Corretor_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}