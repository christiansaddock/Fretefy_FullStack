using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    UF = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Lat = table.Column<double>(type: "REAL", nullable: true),
                    Longi = table.Column<double>(type: "REAL", nullable: true),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Regiao_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regiao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("f36adea6-16db-44ec-97ae-7c48b2490467"), "Região Norte" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e95a703a-0ee0-40bd-8250-526066c88890"), "Região Nordeste" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("ab7fbfad-915f-4745-9f83-0b5f5d7362ee"), "Centro Oeste" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e4888903-59a8-4587-87c0-29adf55af653"), "Região Sudeste" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("083306a6-0207-4132-a1e9-3f06bbe30566"), "Região Sul" });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade",
                column: "RegiaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Regiao");
        }
    }
}
