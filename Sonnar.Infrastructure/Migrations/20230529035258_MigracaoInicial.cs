using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sonnar.Infrastructure.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalistaQA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalistaQA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalistaQA_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Desenvolvedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desenvolvedor_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Metodologia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metodologia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metodologia_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanoDeTeste",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDeTeste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanoDeTeste_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projeto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projeto_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teste",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<long>(type: "bigint", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProjetoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanoDeTesteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnalistaQAId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TesteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teste_AnalistaQA_AnalistaQAId",
                        column: x => x.AnalistaQAId,
                        principalTable: "AnalistaQA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teste_PlanoDeTeste_PlanoDeTesteId",
                        column: x => x.PlanoDeTesteId,
                        principalTable: "PlanoDeTeste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teste_Projeto_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teste_Teste_TesteId",
                        column: x => x.TesteId,
                        principalTable: "Teste",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teste_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MetodologiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesenvolvedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TesteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step_Desenvolvedor_DesenvolvedorId",
                        column: x => x.DesenvolvedorId,
                        principalTable: "Desenvolvedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Step_Metodologia_MetodologiaId",
                        column: x => x.MetodologiaId,
                        principalTable: "Metodologia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Step_Teste_TesteId",
                        column: x => x.TesteId,
                        principalTable: "Teste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalistaQA_UsuarioId",
                table: "AnalistaQA",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Desenvolvedor_UsuarioId",
                table: "Desenvolvedor",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Metodologia_UsuarioId",
                table: "Metodologia",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDeTeste_UsuarioId",
                table: "PlanoDeTeste",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_UsuarioId",
                table: "Projeto",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_DesenvolvedorId",
                table: "Step",
                column: "DesenvolvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_MetodologiaId",
                table: "Step",
                column: "MetodologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_TesteId",
                table: "Step",
                column: "TesteId");

            migrationBuilder.CreateIndex(
                name: "IX_Teste_AnalistaQAId",
                table: "Teste",
                column: "AnalistaQAId");

            migrationBuilder.CreateIndex(
                name: "IX_Teste_PlanoDeTesteId",
                table: "Teste",
                column: "PlanoDeTesteId");

            migrationBuilder.CreateIndex(
                name: "IX_Teste_ProjetoId",
                table: "Teste",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Teste_TesteId",
                table: "Teste",
                column: "TesteId");

            migrationBuilder.CreateIndex(
                name: "IX_Teste_UsuarioId",
                table: "Teste",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Desenvolvedor");

            migrationBuilder.DropTable(
                name: "Metodologia");

            migrationBuilder.DropTable(
                name: "Teste");

            migrationBuilder.DropTable(
                name: "AnalistaQA");

            migrationBuilder.DropTable(
                name: "PlanoDeTeste");

            migrationBuilder.DropTable(
                name: "Projeto");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
