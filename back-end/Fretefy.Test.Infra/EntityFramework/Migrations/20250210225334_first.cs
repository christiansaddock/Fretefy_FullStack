using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0334d8a1-3e05-47a1-a2f2-83e7c9673da2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("089c9fb8-0dad-4ec4-83d9-29ac6fc34b88"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("18bda21f-6af9-4f0a-8c16-4fc7fc134777"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1f298eb3-aeca-4217-a9bc-b72be6e59a52"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2057bccf-1975-4cc3-929c-0c11549d372e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("36d9d738-019a-4237-b854-d3c8d741486f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5a99bcac-ce2d-44b5-8f3f-d25b48dfff9c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("68bc6dee-67af-4d8e-aedc-20efc96371ca"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8009a797-9abb-4a60-abbf-238183ae5327"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("971260e3-3f0d-49af-a8f5-bf3649d11c66"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9acfe167-1000-46dd-8c2d-68c59d7afa1f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a565a4b8-98ea-4434-ac79-10771a860980"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a8a71fd5-8f66-474e-95ca-9f4ddae414b9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b5b66aaa-0ffc-4ceb-b7a8-8054557835f3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bcbedb6b-4abb-467f-b15d-955c31d7fc81"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c6528d61-ea46-4c60-9460-843d7dbf5ddb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cd72e384-4566-4f1c-9696-7d47c5e1c2b5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d3a4ef14-a808-4537-b138-6667b5df6e46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("db4d0f86-23fe-44f0-bcdc-1a524d364abd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("de1c3447-6550-485b-b2f7-ac53f78e790d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dec4198f-1961-46e5-a8a3-ad271819086d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e01b486a-0505-449d-b395-4699c0530124"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e387bb29-c97b-4dbd-8680-a99e84ba7a1d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fa14bf23-00a1-4b3f-a7e8-699d30e23a8c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fcb3a392-0fd1-4bfc-8586-b32235610fed"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fd40ca33-f40d-46b4-88d2-64b232421950"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("feb67e6d-df26-4603-ab25-ab96638e65bd"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegiaoId",
                table: "Cidade",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("37d5bc73-05b0-4a12-a395-dcf4418e6501"), "Rio Branco", null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8a87cba6-da81-425e-8f13-253685f2ef49"), "São Paulo", null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("fa62b57e-251d-472e-a04f-b673072f6617"), "Florianópolis", null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("c371189e-e629-45d9-9e92-69cc59dbf54b"), "Boa Vista", null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("2441f1b0-8970-4e32-a2f2-d3251dfdd250"), "Porto Velho", null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("4c344286-1074-4474-b725-1d8276e9c13c"), "Porto Alegre", null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("7802dfba-eaa9-4e47-9f80-553d8db5260a"), "Natal", null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8119d356-a3e9-47e6-b1fe-5ebbc9e5786a"), "Rio de Janeiro", null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("5723864f-1bf8-41f3-8411-2616a9f413d9"), "Teresina", null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d83d6152-1df0-43d2-b177-9c9d2d9256b7"), "Recife", null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("039dd248-71b1-4699-937d-13c2aac639a9"), "Curitiba", null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("dbce1166-c879-486d-8a56-1ab8bdff5ad3"), "João Pessoa", null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("1ef000ed-d7c2-4aa5-a722-72587073a6ce"), "Aracaju", null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("708d1589-cf3e-49ef-b979-e2693a12b4c8"), "Belém", null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d093bc1c-ed84-49f3-b632-5a9a6d388867"), "Campo Grande", null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("6dc6bdfd-ee37-4f1e-898a-1408c3b4e2f8"), "Cuiabá", null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("589ddbdb-03d0-4210-adba-c3804a3f9d56"), "São Luís", null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("21948646-852d-490c-afac-55da5d633d3a"), "Goiânia", null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("027f8475-1031-4e0d-80b0-29737ac90916"), "Vitória", null, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f4ccc5c5-5c5c-43ca-9e23-9ebb97b082b2"), "Brasília", null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("755370a0-b241-4247-a5cf-006352674caa"), "Fortaleza", null, " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0f542247-9d98-4c6c-b00a-d84577301f3b"), "Salvador", null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("c3b79369-9ef3-4c8c-9f1f-a40878b71568"), "Manaus", null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("77c338ff-5ffa-42d5-b8fa-b9e874811921"), "Macapá", null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a8e825f6-cc2b-4cd0-bef1-fdd97e1829f1"), "Maceió", null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d97a33b1-5a40-463b-88b0-29700fd07df2"), "Belo Horizonte", null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("64dae367-e483-493c-a4b1-ac60595dce16"), "Palmas", null, "TO" });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade",
                column: "RegiaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade",
                column: "RegiaoId",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DropIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("027f8475-1031-4e0d-80b0-29737ac90916"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("039dd248-71b1-4699-937d-13c2aac639a9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0f542247-9d98-4c6c-b00a-d84577301f3b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1ef000ed-d7c2-4aa5-a722-72587073a6ce"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("21948646-852d-490c-afac-55da5d633d3a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2441f1b0-8970-4e32-a2f2-d3251dfdd250"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("37d5bc73-05b0-4a12-a395-dcf4418e6501"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4c344286-1074-4474-b725-1d8276e9c13c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5723864f-1bf8-41f3-8411-2616a9f413d9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("589ddbdb-03d0-4210-adba-c3804a3f9d56"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("64dae367-e483-493c-a4b1-ac60595dce16"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6dc6bdfd-ee37-4f1e-898a-1408c3b4e2f8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("708d1589-cf3e-49ef-b979-e2693a12b4c8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("755370a0-b241-4247-a5cf-006352674caa"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("77c338ff-5ffa-42d5-b8fa-b9e874811921"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7802dfba-eaa9-4e47-9f80-553d8db5260a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8119d356-a3e9-47e6-b1fe-5ebbc9e5786a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8a87cba6-da81-425e-8f13-253685f2ef49"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a8e825f6-cc2b-4cd0-bef1-fdd97e1829f1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c371189e-e629-45d9-9e92-69cc59dbf54b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c3b79369-9ef3-4c8c-9f1f-a40878b71568"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d093bc1c-ed84-49f3-b632-5a9a6d388867"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d83d6152-1df0-43d2-b177-9c9d2d9256b7"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d97a33b1-5a40-463b-88b0-29700fd07df2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dbce1166-c879-486d-8a56-1ab8bdff5ad3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f4ccc5c5-5c5c-43ca-9e23-9ebb97b082b2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fa62b57e-251d-472e-a04f-b673072f6617"));

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Cidade");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("dec4198f-1961-46e5-a8a3-ad271819086d"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c6528d61-ea46-4c60-9460-843d7dbf5ddb"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a8a71fd5-8f66-474e-95ca-9f4ddae414b9"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("68bc6dee-67af-4d8e-aedc-20efc96371ca"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b5b66aaa-0ffc-4ceb-b7a8-8054557835f3"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("36d9d738-019a-4237-b854-d3c8d741486f"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fcb3a392-0fd1-4bfc-8586-b32235610fed"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cd72e384-4566-4f1c-9696-7d47c5e1c2b5"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fa14bf23-00a1-4b3f-a7e8-699d30e23a8c"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a565a4b8-98ea-4434-ac79-10771a860980"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bcbedb6b-4abb-467f-b15d-955c31d7fc81"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("971260e3-3f0d-49af-a8f5-bf3649d11c66"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fd40ca33-f40d-46b4-88d2-64b232421950"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5a99bcac-ce2d-44b5-8f3f-d25b48dfff9c"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d3a4ef14-a808-4537-b138-6667b5df6e46"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2057bccf-1975-4cc3-929c-0c11549d372e"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0334d8a1-3e05-47a1-a2f2-83e7c9673da2"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("18bda21f-6af9-4f0a-8c16-4fc7fc134777"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("de1c3447-6550-485b-b2f7-ac53f78e790d"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("8009a797-9abb-4a60-abbf-238183ae5327"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e387bb29-c97b-4dbd-8680-a99e84ba7a1d"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e01b486a-0505-449d-b395-4699c0530124"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1f298eb3-aeca-4217-a9bc-b72be6e59a52"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("feb67e6d-df26-4603-ab25-ab96638e65bd"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("089c9fb8-0dad-4ec4-83d9-29ac6fc34b88"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("db4d0f86-23fe-44f0-bcdc-1a524d364abd"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9acfe167-1000-46dd-8c2d-68c59d7afa1f"), "Palmas", "TO" });
        }
    }
}
