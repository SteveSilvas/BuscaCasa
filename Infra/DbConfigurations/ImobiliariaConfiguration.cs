using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class ImobiliariaConfiguration : IEntityTypeConfiguration<Imobiliaria>
    {
        public void Configure(EntityTypeBuilder<Imobiliaria> builder)
        {
            builder.ToTable("Imobiliaria");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(m => m.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(i => i.CNPJ)
              .HasColumnName("cnpj")
              .HasColumnType("varchar(14)")
              .IsRequired();

            builder.Property(i => i.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(i => i.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(i => i.EnderecoID)
                .HasColumnName("endereco_id")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(i => i.Endereco)
                .WithMany(e => e.Imobiliarias)
                .HasForeignKey(i => i.EnderecoID)
                .HasConstraintName("Imobiliaria_Endereco_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasMany(i => i.Propriedades) 
                .WithOne(p => p.Imobiliaria)
                .HasForeignKey(p => p.ImobiliariaID)
                .HasConstraintName("Imobiliaria_Propriedade_fkey")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
