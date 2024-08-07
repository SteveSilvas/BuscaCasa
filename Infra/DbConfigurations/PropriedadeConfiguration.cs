using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class PropriedadeConfiguration : IEntityTypeConfiguration<Propriedade>
    {
        public void Configure(EntityTypeBuilder<Propriedade> builder)
        {
            builder.ToTable("Propriedade");

            builder.HasKey(p => p.ID);

            builder.Property(p => p.ID)
                .HasColumnName("id");

            builder.Property(p => p.ProprietarioID)
                .HasColumnName("proprietario_id")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(p => p.Proprietario)
                .WithMany()
                .HasForeignKey(p => p.ProprietarioID)
                .HasConstraintName("Propriedade_Proprietario_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(p => p.ImobiliariaID)
                .HasColumnName("imobiliaria_id")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(p => p.Imobiliaria)
                .WithMany()
                .HasForeignKey(p => p.ImobiliariaID)
                .HasConstraintName("Propriedade_Imobiliaria_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(p => p.ImovelID)
                .HasColumnName("imovel_id")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(p => p.Imovel)
                .WithMany()
                .HasForeignKey(p => p.ImovelID)
                .HasConstraintName("Propriedade_Imovel_fkey")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}