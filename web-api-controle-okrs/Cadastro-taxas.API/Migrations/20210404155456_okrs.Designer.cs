﻿// <auto-generated />
using System;
using Cadastro_taxas.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cadastro_taxas.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210404155456_okrs")]
    partial class okrs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Cadastro_taxas.API.Model.AtividadeKeyResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescricaoAtividade")
                        .HasColumnType("TEXT");

                    b.Property<int?>("KeyResultId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PesoDaAtividade")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PorcentagemConcluidoAtividadePeso")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalConcluido")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("KeyResultId");

                    b.ToTable("Atividades_Resultados_Chaves");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.EmpresaOKR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("TEXT");

                    b.Property<string>("PropostaValor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmpresaOKR");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.KeyResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeKeyResuts")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ObjectKeyResultId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PorcentaAtividadeConcluida")
                        .HasColumnType("REAL");

                    b.Property<string>("Reponsavel")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalConcluidoRelacionadoAoPeso")
                        .HasColumnType("REAL");

                    b.Property<int>("TotalDoPesoDaAtividade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ObjectKeyResultId");

                    b.ToTable("Atividades_Chaves");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.ObjectKeyResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescricaoObjetivo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmpresaOKRId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Porcentagem")
                        .HasColumnType("REAL");

                    b.Property<int>("TotalAtividades")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalRealizado")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaOKRId");

                    b.ToTable("Resultado_Objetos_Chaves");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.PlanejamentoMeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ObjectKeyResultId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Porcentagem")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ObjectKeyResultId");

                    b.ToTable("Planejamento_Metas");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.AtividadeKeyResult", b =>
                {
                    b.HasOne("Cadastro_taxas.API.Model.KeyResult", null)
                        .WithMany("AtividadesKeyResults")
                        .HasForeignKey("KeyResultId");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.KeyResult", b =>
                {
                    b.HasOne("Cadastro_taxas.API.Model.ObjectKeyResult", null)
                        .WithMany("KeysResults")
                        .HasForeignKey("ObjectKeyResultId");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.ObjectKeyResult", b =>
                {
                    b.HasOne("Cadastro_taxas.API.Model.EmpresaOKR", null)
                        .WithMany("ObjectsKeyResults")
                        .HasForeignKey("EmpresaOKRId");
                });

            modelBuilder.Entity("Cadastro_taxas.API.Model.PlanejamentoMeta", b =>
                {
                    b.HasOne("Cadastro_taxas.API.Model.ObjectKeyResult", null)
                        .WithMany("PlanejamentosMetas")
                        .HasForeignKey("ObjectKeyResultId");
                });
#pragma warning restore 612, 618
        }
    }
}
