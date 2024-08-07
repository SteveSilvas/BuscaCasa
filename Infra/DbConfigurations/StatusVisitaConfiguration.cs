using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class StatusVisitaConfiguration : IEntityTypeConfiguration<StatusVisita>
    {
        public void Configure(EntityTypeBuilder<StatusVisita> builder)
        {
            builder.ToTable("Status_Visita");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID)
                .HasColumnName("id");

            builder.Property(s => s.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany(sv => sv.Visitas)
                .WithOne(v => v.StatusVisita)
                .HasForeignKey(v => v.StatusVisitaID)
                .HasConstraintName("Status_Visita_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}