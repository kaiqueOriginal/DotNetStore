using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetSotre.Infra.Data.Migrations
{
    public partial class PrimeiraClasseConfigurada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fotos",
                table: "Varas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Varas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Varas",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fotos",
                table: "Varas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Varas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Varas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);
        }
    }
}
