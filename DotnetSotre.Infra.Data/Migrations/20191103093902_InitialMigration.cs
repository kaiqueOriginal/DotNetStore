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
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Especie = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Camping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    Tamanho = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Peso = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipamentosEletricos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    TipoCorrente = table.Column<int>(nullable: false),
                    Tensao = table.Column<int>(nullable: false),
                    Potencia = table.Column<string>(nullable: true),
                    Peso = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamentosEletricos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipamentosPesca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    CapacidadeCarretel = table.Column<int>(nullable: false),
                    Fabricante = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Rolamentos = table.Column<int>(nullable: false),
                    FreioTipo = table.Column<string>(nullable: true),
                    Manivela = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamentosPesca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iscas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    Validade = table.Column<DateTime>(nullable: false),
                    Fabricante = table.Column<string>(nullable: true),
                    Aroma = table.Column<string>(nullable: true),
                    Peso = table.Column<float>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iscas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rua = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(maxLength: 400, nullable: false),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    Fabricante = table.Column<string>(maxLength: 80, nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Tamanho = table.Column<float>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Libragem = table.Column<int>(nullable: false),
                    Passadores = table.Column<int>(nullable: false),
                    IsInteirica = table.Column<bool>(nullable: false),
                    Acao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decoracao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decoracao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decoracao_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Validade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manutencao_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosHigiene",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Ambiente = table.Column<string>(nullable: true),
                    Toxico = table.Column<bool>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Fabricante = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosHigiene", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutosHigiene_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Aroma = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racoes_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Remedios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    PrecisaReceita = table.Column<bool>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remedios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remedios_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roupas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    Tamanho = table.Column<string>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    FatorProtecaoUV = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    AprovaDagua = table.Column<bool>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roupas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roupas_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viveiros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Preco = table.Column<double>(nullable: false),
                    Fotos = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    StampDateTime = table.Column<DateTime>(nullable: false),
                    Insercao = table.Column<DateTime>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    Suportes = table.Column<int>(nullable: false),
                    Litragem = table.Column<int>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    Medidas = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viveiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viveiros_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    LocalId = table.Column<int>(nullable: false),
                    Chegada = table.Column<DateTime>(nullable: false),
                    Validade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoques_Locais_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Locais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Decoracao_AnimalId",
                table: "Decoracao",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_LocalId",
                table: "Estoques",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_AnimalId",
                table: "Manutencao",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosHigiene_AnimalId",
                table: "ProdutosHigiene",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Racoes_AnimalId",
                table: "Racoes",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Remedios_AnimalId",
                table: "Remedios",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Roupas_AnimalId",
                table: "Roupas",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Viveiros_AnimalId",
                table: "Viveiros",
                column: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camping");

            migrationBuilder.DropTable(
                name: "Decoracao");

            migrationBuilder.DropTable(
                name: "EquipamentosEletricos");

            migrationBuilder.DropTable(
                name: "EquipamentosPesca");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Iscas");

            migrationBuilder.DropTable(
                name: "Manutencao");

            migrationBuilder.DropTable(
                name: "ProdutosHigiene");

            migrationBuilder.DropTable(
                name: "Racoes");

            migrationBuilder.DropTable(
                name: "Remedios");

            migrationBuilder.DropTable(
                name: "Roupas");

            migrationBuilder.DropTable(
                name: "Varas");

            migrationBuilder.DropTable(
                name: "Viveiros");

            migrationBuilder.DropTable(
                name: "Locais");

            migrationBuilder.DropTable(
                name: "Animais");
        }
    }
}
