using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeDataBaseEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedimentoAfereseDoadors");

            migrationBuilder.DropTable(
                name: "ProcedimentoPacientes");

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

            migrationBuilder.DropColumn(
                name: "ComponenteSanguineo",
                table: "SangueColetados");

            migrationBuilder.DropColumn(
                name: "FatorRh",
                table: "SangueColetados");

            migrationBuilder.DropColumn(
                name: "GrupoABO",
                table: "SangueColetados");

            migrationBuilder.DropColumn(
                name: "NomeAnticoagulantePreservativo",
                table: "SangueColetados");

            migrationBuilder.DropColumn(
                name: "TemperaturaAdequada",
                table: "SangueColetados");

            migrationBuilder.DropColumn(
                name: "VolumeComponenteSanguineo",
                table: "SangueColetados");

            migrationBuilder.DropColumn(
                name: "ComponenteSanguineoSolicitado",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ModalidadeDaTransfusao",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HT",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "PressaoArterialDiastolica",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "PressaoArterialSistolica",
                table: "Doadores");

            migrationBuilder.RenameColumn(
                name: "QuantidadeSolicitada",
                table: "Pacientes",
                newName: "QuantidadeSangueSolicitada");

            migrationBuilder.RenameColumn(
                name: "VolumeColetar",
                table: "Doadores",
                newName: "VolumeColetado");

            migrationBuilder.RenameColumn(
                name: "TipoDoacao",
                table: "Doadores",
                newName: "GrupoABO");

            migrationBuilder.RenameColumn(
                name: "Temperatura",
                table: "Doadores",
                newName: "IdUsuario");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Pacientes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FatorRh",
                table: "Doadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Doadores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4004961a-dac0-455e-85bb-fdeb5c205fca", null, "hemocentro", "hemocentro" },
                    { "80367c09-107f-415e-afb0-6f040189ff5f", null, "usuario", "usuario" },
                    { "e6fd023d-dd61-4583-bc6b-cf29dcea70b0", null, "admin", "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Doadores_UsuarioId",
                table: "Doadores",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doadores_AspNetUsers_UsuarioId",
                table: "Doadores",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_AspNetUsers_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doadores_AspNetUsers_UsuarioId",
                table: "Doadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_AspNetUsers_UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Doadores_UsuarioId",
                table: "Doadores");

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

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FatorRh",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Doadores");

            migrationBuilder.RenameColumn(
                name: "QuantidadeSangueSolicitada",
                table: "Pacientes",
                newName: "QuantidadeSolicitada");

            migrationBuilder.RenameColumn(
                name: "VolumeColetado",
                table: "Doadores",
                newName: "VolumeColetar");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Doadores",
                newName: "Temperatura");

            migrationBuilder.RenameColumn(
                name: "GrupoABO",
                table: "Doadores",
                newName: "TipoDoacao");

            migrationBuilder.AddColumn<string>(
                name: "ComponenteSanguineo",
                table: "SangueColetados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "FatorRh",
                table: "SangueColetados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GrupoABO",
                table: "SangueColetados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeAnticoagulantePreservativo",
                table: "SangueColetados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TemperaturaAdequada",
                table: "SangueColetados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "VolumeComponenteSanguineo",
                table: "SangueColetados",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ComponenteSanguineoSolicitado",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModalidadeDaTransfusao",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "HT",
                table: "Doadores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PressaoArterialDiastolica",
                table: "Doadores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PressaoArterialSistolica",
                table: "Doadores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ProcedimentoAfereseDoadors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDoador = table.Column<int>(type: "int", nullable: false),
                    AnticoagulanteUsado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraDaColeta = table.Column<int>(type: "int", nullable: false),
                    TipoComponenteSanguineo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeProduto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentoAfereseDoadors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimentoAfereseDoadors_Doadores_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentoPacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcedimentoTerapeutico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoComponente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoLiquido = table.Column<int>(type: "int", nullable: false),
                    VolumeComponente = table.Column<int>(type: "int", nullable: false),
                    VolumeExtracorporeoProcessado = table.Column<int>(type: "int", nullable: false),
                    VolumeLiquido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentoPacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimentoPacientes_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6b14460-0219-49a1-9959-034cf717bcdb", null, "admin", "admin" },
                    { "d20b7dc3-c442-47d8-86ce-2f9cec58a919", null, "usuario", "usuario" },
                    { "f4479352-1cc5-4bdf-a672-a59fa2c6cbb6", null, "hemocentro", "hemocentro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoAfereseDoadors_IdDoador",
                table: "ProcedimentoAfereseDoadors",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoPacientes_IdPaciente",
                table: "ProcedimentoPacientes",
                column: "IdPaciente");
        }
    }
}
