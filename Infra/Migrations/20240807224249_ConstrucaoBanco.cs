using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class ConstrucaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "Estado",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "Endereco",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateTable(
                name: "Imobiliaria",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(20)", nullable: false),
                    endereco_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imobiliaria", x => x.id);
                    table.ForeignKey(
                        name: "Imobiliaria_Endereco_fkey",
                        column: x => x.endereco_id,
                        principalTable: "Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Status_Imovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_Imovel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Status_Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Status_Visita",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_Visita", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Construcao_Imovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Construcao_Imovel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Uso_Imovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Uso_Imovel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TiposComercializacoes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposComercializacoes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", nullable: false),
                    password_hash = table.Column<byte[]>(type: "bytea", nullable: false),
                    password_salt = table.Column<byte[]>(type: "bytea", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    status = table.Column<int>(type: "integer", nullable: false),
                    tipo_usuario = table.Column<int>(type: "integer", nullable: false),
                    StatusUsuarioID = table.Column<int>(type: "integer", nullable: true),
                    TipoUsuarioID1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuario_Status_Usuario_StatusUsuarioID",
                        column: x => x.StatusUsuarioID,
                        principalTable: "Status_Usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Usuario_Tipo_Usuario_TipoUsuarioID1",
                        column: x => x.TipoUsuarioID1,
                        principalTable: "Tipo_Usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "User_status_fkey",
                        column: x => x.status,
                        principalTable: "Status_Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "User_type_fkey",
                        column: x => x.tipo_usuario,
                        principalTable: "Tipo_Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false),
                    created_at = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    status_imovel = table.Column<int>(type: "int", nullable: false),
                    tipo_uso_imovel = table.Column<int>(type: "int", nullable: false),
                    tipo_construcao_imovel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.id);
                    table.ForeignKey(
                        name: "Status_Imovel_fkey",
                        column: x => x.status_imovel,
                        principalTable: "Status_Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Tipo_Construcao_Imovel_fkey",
                        column: x => x.tipo_construcao_imovel,
                        principalTable: "Tipo_Construcao_Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Tipo_Uso_Imovel_fkey",
                        column: x => x.tipo_uso_imovel,
                        principalTable: "Tipo_Uso_Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Corretor",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sigla = table.Column<string>(type: "varchar(10)", nullable: false),
                    usuario = table.Column<long>(type: "bigint", nullable: false),
                    imobiliaria = table.Column<long>(type: "bigint", nullable: true),
                    ImobiliariaID1 = table.Column<long>(type: "bigint", nullable: true),
                    UsuarioID1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corretor", x => x.id);
                    table.ForeignKey(
                        name: "Corretor_Imobiliaria_fkey",
                        column: x => x.imobiliaria,
                        principalTable: "Imobiliaria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Corretor_Usuario_fkey",
                        column: x => x.usuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Corretor_Imobiliaria_ImobiliariaID1",
                        column: x => x.ImobiliariaID1,
                        principalTable: "Imobiliaria",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Corretor_Usuario_UsuarioID1",
                        column: x => x.UsuarioID1,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Proprietario",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioID1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Proprietario_Usuario_UsuarioID1",
                        column: x => x.UsuarioID1,
                        principalTable: "Usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Usuario_fkey",
                        column: x => x.usuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favorito",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imovel = table.Column<long>(type: "bigint", nullable: false),
                    usuario = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioID1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorito", x => x.id);
                    table.ForeignKey(
                        name: "FK_Favorito_Usuario_UsuarioID1",
                        column: x => x.UsuarioID1,
                        principalTable: "Usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Imovel_Favorito_fkey",
                        column: x => x.imovel,
                        principalTable: "Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "User_Favorito_type_fkey",
                        column: x => x.usuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Comercializacao_Imovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<decimal>(type: "decimal", nullable: false),
                    tipo_comercializacao = table.Column<int>(type: "int", nullable: false),
                    imovel = table.Column<long>(type: "bigint", nullable: false),
                    TipoComercializacaoID1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Comercializacao_Imovel", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tipo_Comercializacao_Imovel_TiposComercializacoes_TipoComer~",
                        column: x => x.TipoComercializacaoID1,
                        principalTable: "TiposComercializacoes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "Tipo_Comercializacao_Imovel_Tipo_Fkey",
                        column: x => x.tipo_comercializacao,
                        principalTable: "TiposComercializacoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Tipo_Comercializacao_Imovel_fkey",
                        column: x => x.imovel,
                        principalTable: "Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visita",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    usuario = table.Column<long>(type: "bigint", nullable: false),
                    imovel = table.Column<long>(type: "bigint", nullable: false),
                    corretor = table.Column<long>(type: "bigint", nullable: false),
                    status_visita = table.Column<int>(type: "int", nullable: false),
                    CorretorID1 = table.Column<long>(type: "bigint", nullable: true),
                    StatusVisitaID1 = table.Column<int>(type: "integer", nullable: true),
                    UsuarioID1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visita", x => x.id);
                    table.ForeignKey(
                        name: "Corretor_fkey",
                        column: x => x.corretor,
                        principalTable: "Corretor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visita_Corretor_CorretorID1",
                        column: x => x.CorretorID1,
                        principalTable: "Corretor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Visita_Status_Visita_StatusVisitaID1",
                        column: x => x.StatusVisitaID1,
                        principalTable: "Status_Visita",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Visita_Usuario_UsuarioID1",
                        column: x => x.UsuarioID1,
                        principalTable: "Usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Imovel_fkey",
                        column: x => x.imovel,
                        principalTable: "Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Status_Visita_fkey",
                        column: x => x.status_visita,
                        principalTable: "Status_Visita",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Usuario_fkey",
                        column: x => x.usuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propriedade",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    proprietario_id = table.Column<long>(type: "bigint", nullable: false),
                    imobiliaria_id = table.Column<long>(type: "bigint", nullable: false),
                    imovel_id = table.Column<long>(type: "bigint", nullable: false),
                    ImobiliariaID1 = table.Column<long>(type: "bigint", nullable: true),
                    ImovelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propriedade", x => x.id);
                    table.ForeignKey(
                        name: "FK_Propriedade_Imobiliaria_ImobiliariaID1",
                        column: x => x.ImobiliariaID1,
                        principalTable: "Imobiliaria",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Propriedade_Imovel_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imovel",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Propriedade_Imobiliaria_fkey",
                        column: x => x.imobiliaria_id,
                        principalTable: "Imobiliaria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Propriedade_Imovel_fkey",
                        column: x => x.imovel_id,
                        principalTable: "Imovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Proprietario_Propriedade_fkey",
                        column: x => x.proprietario_id,
                        principalTable: "Proprietario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corretor_imobiliaria",
                table: "Corretor",
                column: "imobiliaria");

            migrationBuilder.CreateIndex(
                name: "IX_Corretor_ImobiliariaID1",
                table: "Corretor",
                column: "ImobiliariaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Corretor_usuario",
                table: "Corretor",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Corretor_UsuarioID1",
                table: "Corretor",
                column: "UsuarioID1");

            migrationBuilder.CreateIndex(
                name: "IX_Favorito_imovel",
                table: "Favorito",
                column: "imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Favorito_usuario",
                table: "Favorito",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Favorito_UsuarioID1",
                table: "Favorito",
                column: "UsuarioID1");

            migrationBuilder.CreateIndex(
                name: "IX_Imobiliaria_endereco_id",
                table: "Imobiliaria",
                column: "endereco_id");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_status_imovel",
                table: "Imovel",
                column: "status_imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_tipo_construcao_imovel",
                table: "Imovel",
                column: "tipo_construcao_imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Imovel_tipo_uso_imovel",
                table: "Imovel",
                column: "tipo_uso_imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_imobiliaria_id",
                table: "Propriedade",
                column: "imobiliaria_id");

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_ImobiliariaID1",
                table: "Propriedade",
                column: "ImobiliariaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_imovel_id",
                table: "Propriedade",
                column: "imovel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_ImovelId",
                table: "Propriedade",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_proprietario_id",
                table: "Propriedade",
                column: "proprietario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietario_usuario",
                table: "Proprietario",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietario_UsuarioID1",
                table: "Proprietario",
                column: "UsuarioID1");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Comercializacao_Imovel_imovel",
                table: "Tipo_Comercializacao_Imovel",
                column: "imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Comercializacao_Imovel_tipo_comercializacao",
                table: "Tipo_Comercializacao_Imovel",
                column: "tipo_comercializacao");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Comercializacao_Imovel_TipoComercializacaoID1",
                table: "Tipo_Comercializacao_Imovel",
                column: "TipoComercializacaoID1");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_status",
                table: "Usuario",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_StatusUsuarioID",
                table: "Usuario",
                column: "StatusUsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_tipo_usuario",
                table: "Usuario",
                column: "tipo_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoUsuarioID1",
                table: "Usuario",
                column: "TipoUsuarioID1");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_corretor",
                table: "Visita",
                column: "corretor");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_CorretorID1",
                table: "Visita",
                column: "CorretorID1");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_imovel",
                table: "Visita",
                column: "imovel");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_status_visita",
                table: "Visita",
                column: "status_visita");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_StatusVisitaID1",
                table: "Visita",
                column: "StatusVisitaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_usuario",
                table: "Visita",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_UsuarioID1",
                table: "Visita",
                column: "UsuarioID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorito");

            migrationBuilder.DropTable(
                name: "Propriedade");

            migrationBuilder.DropTable(
                name: "Tipo_Comercializacao_Imovel");

            migrationBuilder.DropTable(
                name: "Visita");

            migrationBuilder.DropTable(
                name: "Proprietario");

            migrationBuilder.DropTable(
                name: "TiposComercializacoes");

            migrationBuilder.DropTable(
                name: "Corretor");

            migrationBuilder.DropTable(
                name: "Status_Visita");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "Imobiliaria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Status_Imovel");

            migrationBuilder.DropTable(
                name: "Tipo_Construcao_Imovel");

            migrationBuilder.DropTable(
                name: "Tipo_Uso_Imovel");

            migrationBuilder.DropTable(
                name: "Status_Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "Estado",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Endereco",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false),
                    password_hash = table.Column<byte[]>(type: "bytea", nullable: false),
                    password_salt = table.Column<byte[]>(type: "bytea", nullable: false),
                    tipo_usuario = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Tipo_Usuario_tipo_usuario",
                        column: x => x.tipo_usuario,
                        principalTable: "Tipo_Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "User_status_fkey",
                        column: x => x.status,
                        principalTable: "Status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "User_type_fkey",
                        column: x => x.status,
                        principalTable: "Tipo_Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_status",
                table: "User",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_User_tipo_usuario",
                table: "User",
                column: "tipo_usuario");
        }
    }
}
