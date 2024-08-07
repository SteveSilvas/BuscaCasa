using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    internal class FavoritoConfiguration : IEntityTypeConfiguration<Favorito>
    {
        public void Configure(EntityTypeBuilder<Favorito> builder)
        {
            builder.ToTable("Favorito");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.ID)
                .HasColumnName("id");

            builder.Property(f => f.UsuarioID)
                 .HasColumnName("usuario")
                 .HasColumnType("bigint")
                 .IsRequired();

            builder.HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.UsuarioID)
                .HasConstraintName("User_Favorito_type_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            builder.Property(f => f.ImovelID)
                .HasColumnName("imovel")
                .HasColumnType("bigint")
                .IsRequired();

            builder.HasOne(f => f.Imovel)
                .WithMany(m => m.Favoritos)
                .HasForeignKey(f => f.ImovelID)
                .HasConstraintName("Imovel_Favorito_fkey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
