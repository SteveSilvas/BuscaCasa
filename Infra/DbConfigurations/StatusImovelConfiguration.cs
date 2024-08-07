using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class StatusImovelConfiguration : IEntityTypeConfiguration<StatusImovel>
    {
        public void Configure(EntityTypeBuilder<StatusImovel> builder)
        {
            builder.ToTable("Status_Imovel");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID)
                .HasColumnName("id");

            builder.Property(s => s.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany(si => si.Imoveis)
                .WithOne(i => i.StatusImovel)
                .HasForeignKey(i => i.StatusImovelID)
                .HasConstraintName("Status_Imovel_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
