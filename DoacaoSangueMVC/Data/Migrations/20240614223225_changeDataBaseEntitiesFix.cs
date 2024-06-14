using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeDataBaseEntitiesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4004961a-dac0-455e-85bb-fdeb5c205fca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80367c09-107f-415e-afb0-6f040189ff5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6fd023d-dd61-4583-bc6b-cf29dcea70b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58e37506-f96b-4387-931e-2f7775cec391", null, "usuario", "usuario" },
                    { "92a1bd3e-823a-414a-bb0f-718f43d43126", null, "admin", "admin" },
                    { "c7046903-6c58-43bb-b3cd-0e4aa805c218", null, "hemocentro", "hemocentro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BancoDeSangues_IdDoacao",
                table: "BancoDeSangues",
                column: "IdDoacao");

            migrationBuilder.CreateIndex(
                name: "IX_BancoDeSangues_IdHemocentro",
                table: "BancoDeSangues",
                column: "IdHemocentro");

            migrationBuilder.AddForeignKey(
                name: "FK_BancoDeSangues_Doadores_IdDoacao",
                table: "BancoDeSangues",
                column: "IdDoacao",
                principalTable: "Doadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BancoDeSangues_Hemocentros_IdHemocentro",
                table: "BancoDeSangues",
                column: "IdHemocentro",
                principalTable: "Hemocentros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BancoDeSangues_Doadores_IdDoacao",
                table: "BancoDeSangues");

            migrationBuilder.DropForeignKey(
                name: "FK_BancoDeSangues_Hemocentros_IdHemocentro",
                table: "BancoDeSangues");

            migrationBuilder.DropIndex(
                name: "IX_BancoDeSangues_IdDoacao",
                table: "BancoDeSangues");

            migrationBuilder.DropIndex(
                name: "IX_BancoDeSangues_IdHemocentro",
                table: "BancoDeSangues");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58e37506-f96b-4387-931e-2f7775cec391");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92a1bd3e-823a-414a-bb0f-718f43d43126");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7046903-6c58-43bb-b3cd-0e4aa805c218");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4004961a-dac0-455e-85bb-fdeb5c205fca", null, "hemocentro", "hemocentro" },
                    { "80367c09-107f-415e-afb0-6f040189ff5f", null, "usuario", "usuario" },
                    { "e6fd023d-dd61-4583-bc6b-cf29dcea70b0", null, "admin", "admin" }
                });
        }
    }
}
