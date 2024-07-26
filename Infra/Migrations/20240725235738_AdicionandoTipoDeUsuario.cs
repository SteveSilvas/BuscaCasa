using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTipoDeUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tipo_usuario",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tipo_Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Usuario", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_tipo_usuario",
                table: "User",
                column: "tipo_usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tipo_Usuario_tipo_usuario",
                table: "User",
                column: "tipo_usuario",
                principalTable: "Tipo_Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "User_type_fkey",
                table: "User",
                column: "status",
                principalTable: "Tipo_Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Tipo_Usuario_tipo_usuario",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "User_type_fkey",
                table: "User");

            migrationBuilder.DropTable(
                name: "Tipo_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_User_tipo_usuario",
                table: "User");

            migrationBuilder.DropColumn(
                name: "tipo_usuario",
                table: "User");
        }
    }
}
