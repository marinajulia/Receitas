using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Receitas.Infra.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dificuldade = table.Column<int>(type: "int", nullable: false),
                    Horas = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaFotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReceita = table.Column<int>(type: "int", nullable: false),
                    IdReceitasId = table.Column<int>(type: "int", nullable: true),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaFotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceitaFotos_Receitas_IdReceitasId",
                        column: x => x.IdReceitasId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaFotos_IdReceitasId",
                table: "ReceitaFotos",
                column: "IdReceitasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceitaFotos");

            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
