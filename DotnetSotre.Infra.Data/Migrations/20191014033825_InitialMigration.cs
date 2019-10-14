using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetSotre.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Especie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    Fabricante = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Tamanho = table.Column<float>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Libragem = table.Column<int>(nullable: false),
                    Passadores = table.Column<int>(nullable: false),
                    isInteirica = table.Column<bool>(nullable: false),
                    Acao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Varas");
        }
    }
}
