using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class finishDbFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_TiposSanguineos_ABOID",
                table: "Doadores");

            migrationBuilder.DropIndex(
                name: "IX_Doadores_ABOID",
                table: "Doadores");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2100f861-3ed9-41fe-8446-68ff3fa739e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c6b2fc0-25e0-4b74-a711-73c518de0153");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdb39344-901c-483c-973e-fa1ff09e56d2");

            migrationBuilder.RenameColumn(
                name: "ABOID",
                table: "Doadores",
                newName: "IdTipoSanguineo");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "IdTipoSanguineo",
                table: "Doadores",
                newName: "ABOID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2100f861-3ed9-41fe-8446-68ff3fa739e0", null, "hemocentro", "hemocentro" },
                    { "4c6b2fc0-25e0-4b74-a711-73c518de0153", null, "admin", "admin" },
                    { "fdb39344-901c-483c-973e-fa1ff09e56d2", null, "usuario", "usuario" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doadores_ABOID",
                table: "Doadores",
                column: "ABOID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_TiposSanguineos_ABOID",
                table: "Doadores",
                column: "ABOID",
                principalTable: "TiposSanguineos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
