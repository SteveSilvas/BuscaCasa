using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class RegiaoConfiguration : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.ToTable("Regiao");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .HasColumnName("id");

            builder.Property(r => r.Sigla)
                .HasColumnName("sigla")
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(r => r.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany(r => r.Estados)
                .WithOne(e => e.Regiao)
                .HasForeignKey(e => e.RegiaoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}