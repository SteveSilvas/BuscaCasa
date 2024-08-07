using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class VisitaConfiguration : IEntityTypeConfiguration<Visita>
    {
        public void Configure(EntityTypeBuilder<Visita> builder)
        {
            builder.ToTable("Visita");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(m => m.Data)
                .HasColumnName("data")
                .HasColumnType("TIMESTAMP")
                .IsRequired();

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

            builder.Property(e => e.CorretorID)
                 .HasColumnName("corretor")
                 .HasColumnType("bigint")
                 .IsRequired();

            builder.HasOne(e => e.Corretor)
                .WithMany() 
                .HasForeignKey(e => e.CorretorID)
                .HasConstraintName("Corretor_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(e => e.ImovelID)
               .HasColumnName("imovel")
               .HasColumnType("bigint")
               .IsRequired();

            builder.HasOne(e => e.Imovel)
                .WithMany()
                .HasForeignKey(e => e.ImovelID)
                .HasConstraintName("Imovel_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(e => e.StatusVisitaID)
                .HasColumnName("status_visita")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(e => e.StatusVisita)
                .WithMany()
                .HasForeignKey(e => e.StatusVisitaID)
                .HasConstraintName("Status_Visita_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}