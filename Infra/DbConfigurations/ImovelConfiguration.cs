using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class ImovelConfiguration : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.ToTable("Imovel");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(m => m.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(m => m.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(m => m.CreatedAt)
                .HasColumnName("created_at")
                .HasColumnType("TIMESTAMP")
                .IsRequired();

            builder.Property(m => m.UpdatedAt)
                .HasColumnName("updated_at")
                .HasColumnType("TIMESTAMP")
                .IsRequired();

            builder.Property(m => m.StatusImovelID)
                .HasColumnName("status_imovel")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(m => m.StatusImovel)
                .WithMany()
                .HasForeignKey(m => m.StatusImovelID)
                .HasConstraintName("Status_Imovel_fkey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.TipoUsoImovelID)
                .HasColumnName("tipo_uso_imovel")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(m => m.TipoUsoImovel)
                .WithMany()
                .HasForeignKey(m => m.TipoUsoImovelID)
                .HasConstraintName("Tipo_Uso_Imovel_fkey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.TipoConstrucaoImovelID)
                .HasColumnName("tipo_construcao_imovel")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(m => m.TipoConstrucaoImovel)
                .WithMany()
                .HasForeignKey(m => m.TipoConstrucaoImovelID)
                .HasConstraintName("Tipo_Construcao_Imovel_fkey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Favoritos)
                .WithOne(f => f.Imovel)
                .HasForeignKey(f => f.ImovelID)
                .HasConstraintName("Imovel_Favorito_fkey")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Propriedades)
                .WithOne(p => p.Imovel)
                .HasForeignKey(p => p.ImovelID)
                .HasConstraintName("Imovel_Propriedade_fkey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
