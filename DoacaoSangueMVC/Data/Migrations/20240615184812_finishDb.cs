using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class finishDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_ABO_ABOID",
                table: "Doadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ABO",
                table: "ABO");

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

            migrationBuilder.DropColumn(
                name: "ABO",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsNegativo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPositivo",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ABO",
                newName: "TiposSanguineos");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoSanguineo",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposSanguineos",
                table: "TiposSanguineos",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2100f861-3ed9-41fe-8446-68ff3fa739e0", null, "hemocentro", "hemocentro" },
                    { "4c6b2fc0-25e0-4b74-a711-73c518de0153", null, "admin", "admin" },
                    { "fdb39344-901c-483c-973e-fa1ff09e56d2", null, "usuario", "usuario" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_TiposSanguineos_ABOID",
                table: "Doadores",
                column: "ABOID",
                principalTable: "TiposSanguineos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_TiposSanguineos_ABOID",
                table: "Doadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposSanguineos",
                table: "TiposSanguineos");

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

            migrationBuilder.DropColumn(
                name: "IdTipoSanguineo",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TiposSanguineos",
                newName: "ABO");

            migrationBuilder.AddColumn<string>(
                name: "ABO",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsNegativo",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPositivo",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ABO",
                table: "ABO",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07842e47-f947-4210-95a2-df8c9fe7129a", null, "usuario", "usuario" },
                    { "1a81a3a2-c280-4496-bcc0-cf41022157c9", null, "hemocentro", "hemocentro" },
                    { "95b2082b-cbd3-479d-ad8a-8deecf184058", null, "admin", "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_ABO_ABOID",
                table: "Doadores",
                column: "ABOID",
                principalTable: "ABO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
