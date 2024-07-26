using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DbConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(a => a.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name")
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
                .WithMany() // Aqui você pode especificar o nome da propriedade na classe Status se houver (ex: .WithMany(s => s.Users))
                .HasForeignKey(e => e.StatusId)
                .HasConstraintName("User_status_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(e => e.TipoUsuarioID)
           .HasColumnName("tipo_usuario")
           .HasColumnType("integer")
           .IsRequired();

            builder.HasOne(e => e.TipoUsuario)
                .WithMany() // Aqui você pode especificar o nome da propriedade na classe Status se houver (ex: .WithMany(s => s.Tipos))
                .HasForeignKey(e => e.StatusId)
                .HasConstraintName("User_type_fkey")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
