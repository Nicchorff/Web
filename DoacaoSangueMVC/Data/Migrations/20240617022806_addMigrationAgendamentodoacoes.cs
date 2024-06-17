using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class addMigrationAgendamentodoacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34fbf4aa-bce9-4394-a707-35d4bd7f985c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de15f0dd-ae5f-4c9f-87db-dcc476b917dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe8e6acb-6feb-41e3-9c70-7873837bf10b");

            migrationBuilder.CreateTable(
                name: "DoacoesAgendadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDoacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoSanguineo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdHemocentro = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoacoesAgendadas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27720dea-bd0f-46c8-bfed-c7e2d92edc67", null, "usuario", "usuario" },
                    { "2e879b2b-375e-47f3-8199-ad4255816171", null, "admin", "admin" },
                    { "df47516a-19f0-48cd-a8bb-f06fe14f6af9", null, "hemocentro", "hemocentro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoacoesAgendadas");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27720dea-bd0f-46c8-bfed-c7e2d92edc67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e879b2b-375e-47f3-8199-ad4255816171");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df47516a-19f0-48cd-a8bb-f06fe14f6af9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34fbf4aa-bce9-4394-a707-35d4bd7f985c", null, "admin", "admin" },
                    { "de15f0dd-ae5f-4c9f-87db-dcc476b917dd", null, "usuario", "usuario" },
                    { "fe8e6acb-6feb-41e3-9c70-7873837bf10b", null, "hemocentro", "hemocentro" }
                });
        }
    }
}
