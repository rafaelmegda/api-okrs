using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleOKR.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    PropostaValor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objetivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DefinicaoObjetivo = table.Column<string>(nullable: true),
                    DataParaMeta = table.Column<DateTime>(nullable: false),
                    PorcentagemRealizadaDaMeta = table.Column<double>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objetivos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultadosChaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoResultadoChave = table.Column<string>(nullable: true),
                    Reponsavel = table.Column<string>(nullable: true),
                    ObjetivoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadosChaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultadosChaves_Objetivos_ObjetivoId",
                        column: x => x.ObjetivoId,
                        principalTable: "Objetivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultadosChavesAtividades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoAtividade = table.Column<string>(nullable: true),
                    TotalConcluidoDaAtividade = table.Column<double>(nullable: false),
                    PesoDaAtividade = table.Column<int>(nullable: false),
                    ResultadoChaveId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadosChavesAtividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultadosChavesAtividades_ResultadosChaves_ResultadoChaveId",
                        column: x => x.ResultadoChaveId,
                        principalTable: "ResultadosChaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objetivos_EmpresaId",
                table: "Objetivos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadosChaves_ObjetivoId",
                table: "ResultadosChaves",
                column: "ObjetivoId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadosChavesAtividades_ResultadoChaveId",
                table: "ResultadosChavesAtividades",
                column: "ResultadoChaveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultadosChavesAtividades");

            migrationBuilder.DropTable(
                name: "ResultadosChaves");

            migrationBuilder.DropTable(
                name: "Objetivos");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
