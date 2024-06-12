using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoacaoSangueMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ABO",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "CEP",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CPF",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Emprego",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
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

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidade",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Nascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Naturalidade",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeDaMae",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeDoPai",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrgaoExpedidor",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BancoDeSangues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHemocentro = table.Column<int>(type: "int", nullable: false),
                    IdDoacao = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoDeSangues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadosMedicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRM = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosMedicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDoacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HT = table.Column<double>(type: "float", nullable: false),
                    PressaoArterialSistolica = table.Column<double>(type: "float", nullable: false),
                    PressaoArterialDiastolica = table.Column<double>(type: "float", nullable: false),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    VolumeColetar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hemocentros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<double>(type: "float", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeHemocentro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hemocentros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternado = table.Column<bool>(type: "bit", nullable: false),
                    NomeHospital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroLeito = table.Column<double>(type: "float", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComponenteSanguineoSolicitado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeSolicitada = table.Column<int>(type: "int", nullable: false),
                    ModalidadeDaTransfusao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDaTransfusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    MedicoSolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_DadosMedicos_MedicoSolicitanteId",
                        column: x => x.MedicoSolicitanteId,
                        principalTable: "DadosMedicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentoAfereseDoadors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDoador = table.Column<int>(type: "int", nullable: false),
                    TipoComponenteSanguineo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeProduto = table.Column<double>(type: "float", nullable: false),
                    AnticoagulanteUsado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraDaColeta = table.Column<int>(type: "int", nullable: false)
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
                name: "SangueColetados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHemocentro = table.Column<int>(type: "int", nullable: false),
                    DataColeta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComponenteSanguineo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeComponenteSanguineo = table.Column<double>(type: "float", nullable: false),
                    IdDoacao = table.Column<int>(type: "int", nullable: false),
                    NomeAnticoagulantePreservativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemperaturaAdequada = table.Column<int>(type: "int", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrupoABO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatorRh = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SangueColetados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SangueColetados_Doadores_IdDoacao",
                        column: x => x.IdDoacao,
                        principalTable: "Doadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SangueColetados_Hemocentros_IdHemocentro",
                        column: x => x.IdHemocentro,
                        principalTable: "Hemocentros",
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
                    VolumeExtracorporeoProcessado = table.Column<int>(type: "int", nullable: false),
                    TipoComponente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeComponente = table.Column<int>(type: "int", nullable: false),
                    TipoLiquido = table.Column<int>(type: "int", nullable: false),
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
                    { "1a69643e-c641-49dc-a8aa-de594a5856c9", null, "admin", "admin" },
                    { "2f3befd1-e781-4204-87ab-50b010757ed5", null, "usuario", "usuario" },
                    { "757ef19f-1ae1-4349-b52b-44a504916dcb", null, "hemocentro", "hemocentro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_MedicoSolicitanteId",
                table: "Pacientes",
                column: "MedicoSolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoAfereseDoadors_IdDoador",
                table: "ProcedimentoAfereseDoadors",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentoPacientes_IdPaciente",
                table: "ProcedimentoPacientes",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_SangueColetados_IdDoacao",
                table: "SangueColetados",
                column: "IdDoacao");

            migrationBuilder.CreateIndex(
                name: "IX_SangueColetados_IdHemocentro",
                table: "SangueColetados",
                column: "IdHemocentro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BancoDeSangues");

            migrationBuilder.DropTable(
                name: "ProcedimentoAfereseDoadors");

            migrationBuilder.DropTable(
                name: "ProcedimentoPacientes");

            migrationBuilder.DropTable(
                name: "SangueColetados");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Doadores");

            migrationBuilder.DropTable(
                name: "Hemocentros");

            migrationBuilder.DropTable(
                name: "DadosMedicos");

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

            migrationBuilder.DropColumn(
                name: "ABO",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Emprego",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsNegativo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPositivo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nacionalidade",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Naturalidade",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NomeDaMae",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NomeDoPai",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrgaoExpedidor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "AspNetUsers");
        }
    }
}
