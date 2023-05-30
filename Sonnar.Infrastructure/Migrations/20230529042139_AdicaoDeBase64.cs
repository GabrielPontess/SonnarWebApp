using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sonnar.Infrastructure.Migrations
{
    public partial class AdicaoDeBase64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PerfilBase64",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EvidenciaBase64",
                table: "Teste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerfilBase64",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "EvidenciaBase64",
                table: "Teste");
        }
    }
}
