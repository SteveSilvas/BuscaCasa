using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.DbConfigurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Rua)
                .HasColumnName("rua")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(e => e.Numero)
                .HasColumnName("numero")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(e => e.Complemento)
                .HasColumnName("complemento")
                .HasColumnType("varchar(255)");

            builder.Property(e => e.Bairro)
                .HasColumnName("bairro")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(e => e.CEP)
                .HasColumnName("cep")
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder.HasOne(e => e.Municipio)
                .WithMany(m => m.Enderecos)
                .HasForeignKey(e => e.MunicipioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}