using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    internal class TipoComercializacaoImovelConfiguration : IEntityTypeConfiguration<TipoComercializacaoImovel>
    {
        public void Configure(EntityTypeBuilder<TipoComercializacaoImovel> builder)
        {
            builder.ToTable("Tipo_Comercializacao_Imovel");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(m => m.Valor)
                .HasColumnName("valor")
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(e => e.TipoComercializacaoID)
                    .HasColumnName("tipo_comercializacao")
                    .HasColumnType("int")
                    .IsRequired();

            builder.HasOne(e => e.TipoComercializacao)
                .WithMany()
                .HasForeignKey(e => e.TipoComercializacaoID)
                .HasConstraintName("Tipo_Comercializacao_Imovel_Tipo_Fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(e => e.ImovelID)
                   .HasColumnName("imovel")
                   .HasColumnType("bigint")
                   .IsRequired();

            builder.HasOne(e => e.Imovel)
                .WithMany()
                .HasForeignKey(e => e.ImovelID)
                .HasConstraintName("Tipo_Comercializacao_Imovel_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}