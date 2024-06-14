using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeDataBaseEntitiesFix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "FatorRh",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "GrupoABO",
                table: "Doadores");

            migrationBuilder.AddColumn<int>(
                name: "ABOID",
                table: "Doadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ABO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSanguineo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPositivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABO", x => x.ID);
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
                name: "IX_Doadores_ABOID",
                table: "Doadores",
                column: "ABOID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_ABO_ABOID",
                table: "Doadores",
                column: "ABOID",
                principalTable: "ABO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_ABO_ABOID",
                table: "Doadores");

            migrationBuilder.DropTable(
                name: "ABO");

            migrationBuilder.DropIndex(
                name: "IX_Doadores_ABOID",
                table: "Doadores");

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

            migrationBuilder.DropColumn(
                name: "ABOID",
                table: "Doadores");

            migrationBuilder.AddColumn<bool>(
                name: "FatorRh",
                table: "Doadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GrupoABO",
                table: "Doadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58e37506-f96b-4387-931e-2f7775cec391", null, "usuario", "usuario" },
                    { "92a1bd3e-823a-414a-bb0f-718f43d43126", null, "admin", "admin" },
                    { "c7046903-6c58-43bb-b3cd-0e4aa805c218", null, "hemocentro", "hemocentro" }
                });
        }
    }
}
