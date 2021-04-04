using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_taxas.API.Migrations
{
    public partial class okr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMPRESAS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    PropostaValor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PLANEJAMENTO_METAS_DOS_OBJETIVOS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(nullable: false),
                    Porcentagem = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLANEJAMENTO_METAS_DOS_OBJETIVOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONTROLE_OKRS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmpresasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTROLE_OKRS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CONTROLE_OKRS_EMPRESAS_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "EMPRESAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OBJETIVOS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DefinicaoObjetivo = table.Column<string>(nullable: true),
                    PlanejamentoMetasId = table.Column<int>(nullable: true),
                    ControleDeOKRId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OBJETIVOS", x => x.id);
                    table.ForeignKey(
                        name: "FK_OBJETIVOS_CONTROLE_OKRS_ControleDeOKRId",
                        column: x => x.ControleDeOKRId,
                        principalTable: "CONTROLE_OKRS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OBJETIVOS_PLANEJAMENTO_METAS_DOS_OBJETIVOS_PlanejamentoMetasId",
                        column: x => x.PlanejamentoMetasId,
                        principalTable: "PLANEJAMENTO_METAS_DOS_OBJETIVOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RESULTADO_CHAVE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoResultadoChave = table.Column<string>(nullable: true),
                    Reponsavel = table.Column<string>(nullable: true),
                    Objetivoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESULTADO_CHAVE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RESULTADO_CHAVE_OBJETIVOS_Objetivoid",
                        column: x => x.Objetivoid,
                        principalTable: "OBJETIVOS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RESULTADO_CHAVE_ATIVIDADE",
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
                    table.PrimaryKey("PK_RESULTADO_CHAVE_ATIVIDADE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RESULTADO_CHAVE_ATIVIDADE_RESULTADO_CHAVE_ResultadoChaveId",
                        column: x => x.ResultadoChaveId,
                        principalTable: "RESULTADO_CHAVE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CONTROLE_OKRS_EmpresasId",
                table: "CONTROLE_OKRS",
                column: "EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_OBJETIVOS_ControleDeOKRId",
                table: "OBJETIVOS",
                column: "ControleDeOKRId");

            migrationBuilder.CreateIndex(
                name: "IX_OBJETIVOS_PlanejamentoMetasId",
                table: "OBJETIVOS",
                column: "PlanejamentoMetasId");

            migrationBuilder.CreateIndex(
                name: "IX_RESULTADO_CHAVE_Objetivoid",
                table: "RESULTADO_CHAVE",
                column: "Objetivoid");

            migrationBuilder.CreateIndex(
                name: "IX_RESULTADO_CHAVE_ATIVIDADE_ResultadoChaveId",
                table: "RESULTADO_CHAVE_ATIVIDADE",
                column: "ResultadoChaveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RESULTADO_CHAVE_ATIVIDADE");

            migrationBuilder.DropTable(
                name: "RESULTADO_CHAVE");

            migrationBuilder.DropTable(
                name: "OBJETIVOS");

            migrationBuilder.DropTable(
                name: "CONTROLE_OKRS");

            migrationBuilder.DropTable(
                name: "PLANEJAMENTO_METAS_DOS_OBJETIVOS");

            migrationBuilder.DropTable(
                name: "EMPRESAS");
        }
    }
}
