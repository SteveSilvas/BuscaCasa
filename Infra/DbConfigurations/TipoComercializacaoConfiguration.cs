using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class TipoComercializacaoConfiguration : IEntityTypeConfiguration<TipoComercializacaoImovel>
    {
        public void Configure(EntityTypeBuilder<TipoComercializacaoImovel> builder)
        {
            builder.ToTable("TipoComercializacaoImovel");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.ID)
                .HasColumnName("id");

            builder.Property(t => t.Valor)
                .HasColumnName("valor")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(t => t.TipoComercializacaoID)
                .HasColumnName("tipo_comercializacao_id")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(t => t.TipoComercializacao)
                .WithMany()
                .HasForeignKey(t => t.TipoComercializacaoID)
                .HasConstraintName("Tipo_Comercializacao_fkey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.ImovelID)
                .HasColumnName("imovel_id")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(t => t.Imovel)
                .WithMany()
                .HasForeignKey(t => t.ImovelID)
                .HasConstraintName("Imovel_TipoComercializacao_fkey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}