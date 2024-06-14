using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixBancoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BancoDeSangues");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afd1873c-2a28-4787-9ca9-09387fb0a4f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda43fae-57b2-4568-9236-e8012f2da3b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eeeb1fa4-ad5e-47b3-8919-a75250f3e18f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07842e47-f947-4210-95a2-df8c9fe7129a", null, "usuario", "usuario" },
                    { "1a81a3a2-c280-4496-bcc0-cf41022157c9", null, "hemocentro", "hemocentro" },
                    { "95b2082b-cbd3-479d-ad8a-8deecf184058", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07842e47-f947-4210-95a2-df8c9fe7129a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a81a3a2-c280-4496-bcc0-cf41022157c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95b2082b-cbd3-479d-ad8a-8deecf184058");

            migrationBuilder.CreateTable(
                name: "BancoDeSangues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDoacao = table.Column<int>(type: "int", nullable: false),
                    IdHemocentro = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoDeSangues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BancoDeSangues_Doadores_IdDoacao",
                        column: x => x.IdDoacao,
                        principalTable: "Doadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BancoDeSangues_Hemocentros_IdHemocentro",
                        column: x => x.IdHemocentro,
                        principalTable: "Hemocentros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "afd1873c-2a28-4787-9ca9-09387fb0a4f0", null, "admin", "admin" },
                    { "bda43fae-57b2-4568-9236-e8012f2da3b1", null, "hemocentro", "hemocentro" },
                    { "eeeb1fa4-ad5e-47b3-8919-a75250f3e18f", null, "usuario", "usuario" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BancoDeSangues_IdDoacao",
                table: "BancoDeSangues",
                column: "IdDoacao");

            migrationBuilder.CreateIndex(
                name: "IX_BancoDeSangues_IdHemocentro",
                table: "BancoDeSangues",
                column: "IdHemocentro");
        }
    }
}
