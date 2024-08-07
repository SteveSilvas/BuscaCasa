using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class TipoConstrucaoImovelConfiguration : IEntityTypeConfiguration<TipoConstrucaoImovel>
    {
        public void Configure(EntityTypeBuilder<TipoConstrucaoImovel> builder)
        {
            builder.ToTable("Tipo_Construcao_Imovel");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(m => m.Descricao)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany(t => t.Imoveis)
                 .WithOne(i => i.TipoConstrucaoImovel)
                 .HasForeignKey(i => i.TipoConstrucaoImovelID)
                 .HasConstraintName("Tipo_Construcao_Imovel_fkey")
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}