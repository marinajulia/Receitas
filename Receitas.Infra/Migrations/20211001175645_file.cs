using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas.Infra.Migrations
{
    public partial class file : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Format",
                table: "ReceitaFotos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Format",
                table: "ReceitaFotos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
