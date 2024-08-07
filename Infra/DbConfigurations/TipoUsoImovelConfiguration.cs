using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class TipoUsoImovelConfiguration : IEntityTypeConfiguration<TipoUsoImovel>
    {
        public void Configure(EntityTypeBuilder<TipoUsoImovel> builder)
        {
            builder.ToTable("Tipo_Uso_Imovel");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(m => m.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();


            builder.HasMany(t => t.Imoveis)
                  .WithOne(i => i.TipoUsoImovel)
                  .HasForeignKey(i => i.TipoUsoImovelID)
                  .HasConstraintName("Tipo_Uso_Imovel_fkey")
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}