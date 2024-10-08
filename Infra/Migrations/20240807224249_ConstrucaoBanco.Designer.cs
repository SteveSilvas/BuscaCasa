﻿// <auto-generated />
using System;
using Authenticator.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(PostgresDbContext))]
    [Migration("20240807224249_ConstrucaoBanco")]
    partial class ConstrucaoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Corretor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("ImobiliariaID")
                        .HasColumnType("bigint")
                        .HasColumnName("imobiliaria");

                    b.Property<long?>("ImobiliariaID1")
                        .HasColumnType("bigint");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("sigla");

                    b.Property<long>("UsuarioID")
                        .HasColumnType("bigint")
                        .HasColumnName("usuario");

                    b.Property<long?>("UsuarioID1")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ImobiliariaID");

                    b.HasIndex("ImobiliariaID1");

                    b.HasIndex("UsuarioID");

                    b.HasIndex("UsuarioID1");

                    b.ToTable("Corretor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Endereco", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("cep");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("complemento");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("integer");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("rua");

                    b.HasKey("ID");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Endereco", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<int>("RegiaoId")
                        .HasColumnType("integer");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasColumnName("sigla");

                    b.HasKey("ID");

                    b.HasIndex("RegiaoId");

                    b.ToTable("Estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Favorito", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("ImovelID")
                        .HasColumnType("bigint")
                        .HasColumnName("imovel");

                    b.Property<long>("UsuarioID")
                        .HasColumnType("bigint")
                        .HasColumnName("usuario");

                    b.Property<long?>("UsuarioID1")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ImovelID");

                    b.HasIndex("UsuarioID");

                    b.HasIndex("UsuarioID1");

                    b.ToTable("Favorito", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Imobiliaria", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("cnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<long>("EnderecoID")
                        .HasColumnType("bigint")
                        .HasColumnName("endereco_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefone");

                    b.HasKey("ID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Imobiliaria", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Imovel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("created_at");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<int>("StatusImovelID")
                        .HasColumnType("int")
                        .HasColumnName("status_imovel");

                    b.Property<int>("TipoConstrucaoImovelID")
                        .HasColumnType("int")
                        .HasColumnName("tipo_construcao_imovel");

                    b.Property<int>("TipoUsoImovelID")
                        .HasColumnType("int")
                        .HasColumnName("tipo_uso_imovel");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("StatusImovelID");

                    b.HasIndex("TipoConstrucaoImovelID");

                    b.HasIndex("TipoUsoImovelID");

                    b.ToTable("Imovel", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Municipio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("EstadoId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.HasKey("ID");

                    b.HasIndex("EstadoId");

                    b.ToTable("Municipio", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Propriedade", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("ImobiliariaID")
                        .HasColumnType("bigint")
                        .HasColumnName("imobiliaria_id");

                    b.Property<long?>("ImobiliariaID1")
                        .HasColumnType("bigint");

                    b.Property<long>("ImovelID")
                        .HasColumnType("bigint")
                        .HasColumnName("imovel_id");

                    b.Property<long?>("ImovelId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProprietarioID")
                        .HasColumnType("bigint")
                        .HasColumnName("proprietario_id");

                    b.HasKey("ID");

                    b.HasIndex("ImobiliariaID");

                    b.HasIndex("ImobiliariaID1");

                    b.HasIndex("ImovelID");

                    b.HasIndex("ImovelId");

                    b.HasIndex("ProprietarioID");

                    b.ToTable("Propriedade", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proprietario", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("UsuarioID")
                        .HasColumnType("bigint")
                        .HasColumnName("usuario");

                    b.Property<long?>("UsuarioID1")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.HasIndex("UsuarioID1");

                    b.ToTable("Proprietario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Regiao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("sigla");

                    b.HasKey("ID");

                    b.ToTable("Regiao", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.StatusImovel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("ID");

                    b.ToTable("Status_Imovel", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.StatusUsuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("ID");

                    b.ToTable("Status_Usuario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.StatusVisita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("ID");

                    b.ToTable("Status_Visita", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoComercializacao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("TiposComercializacoes");
                });

            modelBuilder.Entity("Domain.Entities.TipoComercializacaoImovel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<long>("ImovelID")
                        .HasColumnType("bigint")
                        .HasColumnName("imovel");

                    b.Property<int>("TipoComercializacaoID")
                        .HasColumnType("int")
                        .HasColumnName("tipo_comercializacao");

                    b.Property<int?>("TipoComercializacaoID1")
                        .HasColumnType("integer");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal")
                        .HasColumnName("valor");

                    b.HasKey("ID");

                    b.HasIndex("ImovelID");

                    b.HasIndex("TipoComercializacaoID");

                    b.HasIndex("TipoComercializacaoID1");

                    b.ToTable("Tipo_Comercializacao_Imovel", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoConstrucaoImovel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.HasKey("ID");

                    b.ToTable("Tipo_Construcao_Imovel", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoUsoImovel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("ID");

                    b.ToTable("Tipo_Uso_Imovel", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoUsuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("ID");

                    b.ToTable("Tipo_Usuario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("password_hash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("password_salt");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int?>("StatusUsuarioID")
                        .HasColumnType("integer");

                    b.Property<int>("TipoUsuarioID")
                        .HasColumnType("integer")
                        .HasColumnName("tipo_usuario");

                    b.Property<int?>("TipoUsuarioID1")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("ID");

                    b.HasIndex("StatusId");

                    b.HasIndex("StatusUsuarioID");

                    b.HasIndex("TipoUsuarioID");

                    b.HasIndex("TipoUsuarioID1");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Visita", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("CorretorID")
                        .HasColumnType("bigint")
                        .HasColumnName("corretor");

                    b.Property<long?>("CorretorID1")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("data");

                    b.Property<long>("ImovelID")
                        .HasColumnType("bigint")
                        .HasColumnName("imovel");

                    b.Property<int>("StatusVisitaID")
                        .HasColumnType("int")
                        .HasColumnName("status_visita");

                    b.Property<int?>("StatusVisitaID1")
                        .HasColumnType("integer");

                    b.Property<long>("UsuarioID")
                        .HasColumnType("bigint")
                        .HasColumnName("usuario");

                    b.Property<long?>("UsuarioID1")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CorretorID");

                    b.HasIndex("CorretorID1");

                    b.HasIndex("ImovelID");

                    b.HasIndex("StatusVisitaID");

                    b.HasIndex("StatusVisitaID1");

                    b.HasIndex("UsuarioID");

                    b.HasIndex("UsuarioID1");

                    b.ToTable("Visita", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Corretor", b =>
                {
                    b.HasOne("Domain.Entities.Imobiliaria", "Imobiliaria")
                        .WithMany()
                        .HasForeignKey("ImobiliariaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("Corretor_Imobiliaria_fkey");

                    b.HasOne("Domain.Entities.Imobiliaria", null)
                        .WithMany("Corretores")
                        .HasForeignKey("ImobiliariaID1");

                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Corretor_Usuario_fkey");

                    b.HasOne("Domain.Entities.Usuario", null)
                        .WithMany("Corretores")
                        .HasForeignKey("UsuarioID1");

                    b.Navigation("Imobiliaria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Endereco", b =>
                {
                    b.HasOne("Domain.Entities.Municipio", "Municipio")
                        .WithMany("Enderecos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.HasOne("Domain.Entities.Regiao", "Regiao")
                        .WithMany("Estados")
                        .HasForeignKey("RegiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regiao");
                });

            modelBuilder.Entity("Domain.Entities.Favorito", b =>
                {
                    b.HasOne("Domain.Entities.Imovel", "Imovel")
                        .WithMany("Favoritos")
                        .HasForeignKey("ImovelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Imovel_Favorito_fkey");

                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("User_Favorito_type_fkey");

                    b.HasOne("Domain.Entities.Usuario", null)
                        .WithMany("Favoritos")
                        .HasForeignKey("UsuarioID1");

                    b.Navigation("Imovel");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Imobiliaria", b =>
                {
                    b.HasOne("Domain.Entities.Endereco", "Endereco")
                        .WithMany("Imobiliarias")
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Imobiliaria_Endereco_fkey");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Domain.Entities.Imovel", b =>
                {
                    b.HasOne("Domain.Entities.StatusImovel", "StatusImovel")
                        .WithMany("Imoveis")
                        .HasForeignKey("StatusImovelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Status_Imovel_fkey");

                    b.HasOne("Domain.Entities.TipoConstrucaoImovel", "TipoConstrucaoImovel")
                        .WithMany("Imoveis")
                        .HasForeignKey("TipoConstrucaoImovelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Tipo_Construcao_Imovel_fkey");

                    b.HasOne("Domain.Entities.TipoUsoImovel", "TipoUsoImovel")
                        .WithMany("Imoveis")
                        .HasForeignKey("TipoUsoImovelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Tipo_Uso_Imovel_fkey");

                    b.Navigation("StatusImovel");

                    b.Navigation("TipoConstrucaoImovel");

                    b.Navigation("TipoUsoImovel");
                });

            modelBuilder.Entity("Domain.Entities.Municipio", b =>
                {
                    b.HasOne("Domain.Entities.Estado", "Estado")
                        .WithMany("Municipios")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Domain.Entities.Propriedade", b =>
                {
                    b.HasOne("Domain.Entities.Imobiliaria", "Imobiliaria")
                        .WithMany()
                        .HasForeignKey("ImobiliariaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Propriedade_Imobiliaria_fkey");

                    b.HasOne("Domain.Entities.Imobiliaria", null)
                        .WithMany("Propriedades")
                        .HasForeignKey("ImobiliariaID1");

                    b.HasOne("Domain.Entities.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Propriedade_Imovel_fkey");

                    b.HasOne("Domain.Entities.Imovel", null)
                        .WithMany("Propriedades")
                        .HasForeignKey("ImovelId");

                    b.HasOne("Domain.Entities.Proprietario", "Proprietario")
                        .WithMany("Propriedades")
                        .HasForeignKey("ProprietarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Proprietario_Propriedade_fkey");

                    b.Navigation("Imobiliaria");

                    b.Navigation("Imovel");

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("Domain.Entities.Proprietario", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Usuario_fkey");

                    b.HasOne("Domain.Entities.Usuario", null)
                        .WithMany("Proprietarios")
                        .HasForeignKey("UsuarioID1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.TipoComercializacaoImovel", b =>
                {
                    b.HasOne("Domain.Entities.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Tipo_Comercializacao_Imovel_fkey");

                    b.HasOne("Domain.Entities.TipoComercializacao", "TipoComercializacao")
                        .WithMany()
                        .HasForeignKey("TipoComercializacaoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Tipo_Comercializacao_Imovel_Tipo_Fkey");

                    b.HasOne("Domain.Entities.TipoComercializacao", null)
                        .WithMany("TiposComercializacoesImoveis")
                        .HasForeignKey("TipoComercializacaoID1");

                    b.Navigation("Imovel");

                    b.Navigation("TipoComercializacao");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Domain.Entities.StatusUsuario", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("User_status_fkey");

                    b.HasOne("Domain.Entities.StatusUsuario", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("StatusUsuarioID");

                    b.HasOne("Domain.Entities.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("User_type_fkey");

                    b.HasOne("Domain.Entities.TipoUsuario", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoUsuarioID1");

                    b.Navigation("Status");

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("Domain.Entities.Visita", b =>
                {
                    b.HasOne("Domain.Entities.Corretor", "Corretor")
                        .WithMany()
                        .HasForeignKey("CorretorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Corretor_fkey");

                    b.HasOne("Domain.Entities.Corretor", null)
                        .WithMany("Visitas")
                        .HasForeignKey("CorretorID1");

                    b.HasOne("Domain.Entities.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Imovel_fkey");

                    b.HasOne("Domain.Entities.StatusVisita", "StatusVisita")
                        .WithMany()
                        .HasForeignKey("StatusVisitaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Status_Visita_fkey");

                    b.HasOne("Domain.Entities.StatusVisita", null)
                        .WithMany("Visitas")
                        .HasForeignKey("StatusVisitaID1");

                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Usuario_fkey");

                    b.HasOne("Domain.Entities.Usuario", null)
                        .WithMany("Visitas")
                        .HasForeignKey("UsuarioID1");

                    b.Navigation("Corretor");

                    b.Navigation("Imovel");

                    b.Navigation("StatusVisita");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Corretor", b =>
                {
                    b.Navigation("Visitas");
                });

            modelBuilder.Entity("Domain.Entities.Endereco", b =>
                {
                    b.Navigation("Imobiliarias");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("Domain.Entities.Imobiliaria", b =>
                {
                    b.Navigation("Corretores");

                    b.Navigation("Propriedades");
                });

            modelBuilder.Entity("Domain.Entities.Imovel", b =>
                {
                    b.Navigation("Favoritos");

                    b.Navigation("Propriedades");
                });

            modelBuilder.Entity("Domain.Entities.Municipio", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("Domain.Entities.Proprietario", b =>
                {
                    b.Navigation("Propriedades");
                });

            modelBuilder.Entity("Domain.Entities.Regiao", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Domain.Entities.StatusImovel", b =>
                {
                    b.Navigation("Imoveis");
                });

            modelBuilder.Entity("Domain.Entities.StatusUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Domain.Entities.StatusVisita", b =>
                {
                    b.Navigation("Visitas");
                });

            modelBuilder.Entity("Domain.Entities.TipoComercializacao", b =>
                {
                    b.Navigation("TiposComercializacoesImoveis");
                });

            modelBuilder.Entity("Domain.Entities.TipoConstrucaoImovel", b =>
                {
                    b.Navigation("Imoveis");
                });

            modelBuilder.Entity("Domain.Entities.TipoUsoImovel", b =>
                {
                    b.Navigation("Imoveis");
                });

            modelBuilder.Entity("Domain.Entities.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Corretores");

                    b.Navigation("Favoritos");

                    b.Navigation("Proprietarios");

                    b.Navigation("Visitas");
                });
#pragma warning restore 612, 618
        }
    }
}
