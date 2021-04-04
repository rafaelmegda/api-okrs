using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_taxas.API.Migrations
{
    public partial class okrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaOKR",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    PropostaValor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaOKR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resultado_Objetos_Chaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoObjetivo = table.Column<string>(nullable: true),
                    TotalAtividades = table.Column<int>(nullable: false),
                    TotalRealizado = table.Column<int>(nullable: false),
                    Porcentagem = table.Column<double>(nullable: false),
                    EmpresaOKRId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultado_Objetos_Chaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resultado_Objetos_Chaves_EmpresaOKR_EmpresaOKRId",
                        column: x => x.EmpresaOKRId,
                        principalTable: "EmpresaOKR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atividades_Chaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeKeyResuts = table.Column<string>(nullable: true),
                    Reponsavel = table.Column<string>(nullable: true),
                    PorcentaAtividadeConcluida = table.Column<double>(nullable: false),
                    TotalConcluidoRelacionadoAoPeso = table.Column<double>(nullable: false),
                    TotalDoPesoDaAtividade = table.Column<int>(nullable: false),
                    ObjectKeyResultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades_Chaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividades_Chaves_Resultado_Objetos_Chaves_ObjectKeyResultId",
                        column: x => x.ObjectKeyResultId,
                        principalTable: "Resultado_Objetos_Chaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Planejamento_Metas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(nullable: false),
                    Porcentagem = table.Column<double>(nullable: false),
                    ObjectKeyResultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planejamento_Metas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planejamento_Metas_Resultado_Objetos_Chaves_ObjectKeyResultId",
                        column: x => x.ObjectKeyResultId,
                        principalTable: "Resultado_Objetos_Chaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atividades_Resultados_Chaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescricaoAtividade = table.Column<string>(nullable: true),
                    TotalConcluido = table.Column<double>(nullable: false),
                    PorcentagemConcluidoAtividadePeso = table.Column<double>(nullable: false),
                    PesoDaAtividade = table.Column<int>(nullable: false),
                    KeyResultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades_Resultados_Chaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividades_Resultados_Chaves_Atividades_Chaves_KeyResultId",
                        column: x => x.KeyResultId,
                        principalTable: "Atividades_Chaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_Chaves_ObjectKeyResultId",
                table: "Atividades_Chaves",
                column: "ObjectKeyResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_Resultados_Chaves_KeyResultId",
                table: "Atividades_Resultados_Chaves",
                column: "KeyResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Planejamento_Metas_ObjectKeyResultId",
                table: "Planejamento_Metas",
                column: "ObjectKeyResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Resultado_Objetos_Chaves_EmpresaOKRId",
                table: "Resultado_Objetos_Chaves",
                column: "EmpresaOKRId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atividades_Resultados_Chaves");

            migrationBuilder.DropTable(
                name: "Planejamento_Metas");

            migrationBuilder.DropTable(
                name: "Atividades_Chaves");

            migrationBuilder.DropTable(
                name: "Resultado_Objetos_Chaves");

            migrationBuilder.DropTable(
                name: "EmpresaOKR");
        }
    }
}
