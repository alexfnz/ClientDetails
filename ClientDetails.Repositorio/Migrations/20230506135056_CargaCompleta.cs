using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientDetails.Repositorio.Migrations
{
    public partial class CargaCompleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Endereco = table.Column<string>(maxLength: 50, nullable: false),
                    Segmento = table.Column<string>(maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(maxLength: 50, nullable: false),
                    CodSistema = table.Column<string>(maxLength: 50, nullable: false),
                    CodExterno = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Cargo = table.Column<string>(maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoTarefa = table.Column<string>(maxLength: 50, nullable: false),
                    DataExecucao = table.Column<DateTime>(nullable: false),
                    Colaborador = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cnpj", "CodExterno", "CodSistema", "Email", "Endereco", "Nome", "Segmento", "Telefone" },
                values: new object[] { 1, "98.654.321/0009-88", "321", "4567", "cliente@teste.com", "Rua dotnet, 2220", "FNZ Inc", "TI", "6295555-5555" });

            migrationBuilder.InsertData(
                table: "Contatos",
                columns: new[] { "Id", "Cargo", "Email", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Dev", "contatodev@teste.com", "Eliana", "6299999-9999" },
                    { 2, "RH", "contatorh@teste.com", "Roberto", "6299999-9999" },
                    { 3, "Suporte", "contatosup@teste.com", "Alan", "6299999-9999" }
                });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "Id", "Colaborador", "DataExecucao", "TipoTarefa" },
                values: new object[,]
                {
                    { 1, "Roberto", new DateTime(2023, 5, 6, 10, 50, 55, 858, DateTimeKind.Local).AddTicks(6421), "Corretiva" },
                    { 2, "Eliana", new DateTime(2023, 5, 6, 10, 50, 55, 859, DateTimeKind.Local).AddTicks(2974), "Preventiva" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
