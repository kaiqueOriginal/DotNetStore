using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetSotre.Infra.Data.Migrations
{
    public partial class PrimeiraClasseConfigurada2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fotos",
                table: "Varas",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Varas",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Animais",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Especie",
                table: "Animais",
                nullable: false,
                defaultValue: "100",
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fotos",
                table: "Varas",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Varas",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Animais",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Especie",
                table: "Animais",
                nullable: true,
                oldClrType: typeof(string),
                oldDefaultValue: "100");
        }
    }
}
