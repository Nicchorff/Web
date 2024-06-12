using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class HemocentroAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a69643e-c641-49dc-a8aa-de594a5856c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f3befd1-e781-4204-87ab-50b010757ed5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "757ef19f-1ae1-4349-b52b-44a504916dcb");

            migrationBuilder.DeleteData(
                table: "Hemocentros",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hemocentros",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hemocentros",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hemocentros",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hemocentros",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6b14460-0219-49a1-9959-034cf717bcdb", null, "admin", "admin" },
                    { "d20b7dc3-c442-47d8-86ce-2f9cec58a919", null, "usuario", "usuario" },
                    { "f4479352-1cc5-4bdf-a672-a59fa2c6cbb6", null, "hemocentro", "hemocentro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6b14460-0219-49a1-9959-034cf717bcdb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d20b7dc3-c442-47d8-86ce-2f9cec58a919");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4479352-1cc5-4bdf-a672-a59fa2c6cbb6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a69643e-c641-49dc-a8aa-de594a5856c9", null, "admin", "admin" },
                    { "2f3befd1-e781-4204-87ab-50b010757ed5", null, "usuario", "usuario" },
                    { "757ef19f-1ae1-4349-b52b-44a504916dcb", null, "hemocentro", "hemocentro" }
                });

            migrationBuilder.InsertData(
                table: "Hemocentros",
                columns: new[] { "Id", "CEP", "Email", "Endereco", "Nome", "NomeHemocentro", "Referencia", "Telefone" },
                values: new object[,]
                {
                    { 1, 12345.67, "contato@hemocentro1.com", "Rua dos Hemocentros, 123", "Hemocentro Central", "Hemocentro Central", "Perto do hospital central", 1234567890.0 },
                    { 2, 23456.779999999999, "contato@hemocentro2.com", "Avenida dos Doadores, 456", "Hemocentro Regional", "Hemocentro Regional", "Ao lado da clínica de saúde", 9876543210.0 },
                    { 3, 34567.889999999999, "contato@hemocentro3.com", "Praça das Doações, 789", "Hemocentro Municipal", "Hemocentro Municipal", "Próximo à prefeitura", 2468135790.0 },
                    { 4, 45678.900000000001, "contato@hemocentro4.com", "Alameda dos Dadores, 987", "Hemocentro Estadual", "Hemocentro Estadual", "Em frente ao parque", 1357924680.0 },
                    { 5, 56789.010000000002, "contato@hemocentro5.com", "Travessa dos Doadores, 654", "Hemocentro Nacional", "Hemocentro Nacional", "No centro da cidade", 8024681357.0 }
                });
        }
    }
}
