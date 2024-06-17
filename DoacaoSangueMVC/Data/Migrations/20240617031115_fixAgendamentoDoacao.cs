using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixAgendamentoDoacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "DoacoesAgendadas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "491c62ba-7555-4d75-8c64-be60bdd9e7a1", null, "admin", "admin" },
                    { "51889533-ba4f-4bb9-b5d0-4a2978aed9d0", null, "usuario", "usuario" },
                    { "6bfe7217-c800-4589-bc10-952d04d1a648", null, "hemocentro", "hemocentro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "491c62ba-7555-4d75-8c64-be60bdd9e7a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51889533-ba4f-4bb9-b5d0-4a2978aed9d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bfe7217-c800-4589-bc10-952d04d1a648");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "DoacoesAgendadas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
