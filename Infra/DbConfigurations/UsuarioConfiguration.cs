using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(a => a.ID);

            builder.Property(e => e.ID)
                .HasColumnName("id");

            builder.Property(e => e.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(e => e.PasswordHash)
                .HasColumnName("password_hash")
                .HasColumnType("bytea")
                .IsRequired();

            builder.Property(e => e.PasswordSalt)
                .HasColumnName("password_salt")
                .HasColumnType("bytea")
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .HasColumnName("created_at")
                .HasColumnType("timestamp")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.UpdatedAt)
                .HasColumnName("updated_at")
                .HasColumnType("timestamp")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.StatusId)
                .HasColumnName("status")
                .HasColumnType("integer")
                .IsRequired();

            builder.HasOne(e => e.Status)
                .WithMany()
                .HasForeignKey(e => e.StatusId)
                .HasConstraintName("User_status_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(e => e.TipoUsuarioID)
               .HasColumnName("tipo_usuario")
               .HasColumnType("integer")
               .IsRequired();

            builder.HasOne(e => e.TipoUsuario)
                .WithMany()
                .HasForeignKey(e => e.TipoUsuarioID)
                .HasConstraintName("User_type_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
