﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sonnar.Infrastructure;

#nullable disable

namespace Sonnar.Infrastructure.Migrations
{
    [DbContext(typeof(SonnarDbContext))]
    partial class SonnarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sonnar.Domain.Models.AnalistaQA", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("AnalistaQA");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Desenvolvedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Desenvolvedor");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Metodologia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Metodologia");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.PlanoDeTeste", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PlanoDeTeste");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Projeto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DesenvolvedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MetodologiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("TesteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DesenvolvedorId");

                    b.HasIndex("MetodologiaId");

                    b.HasIndex("TesteId");

                    b.ToTable("Step");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Teste", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnalistaQAId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvidenciaBase64")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Numero")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PlanoDeTesteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjetoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TesteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnalistaQAId");

                    b.HasIndex("PlanoDeTesteId");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("TesteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Teste");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerfilBase64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.AnalistaQA", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.Usuario", "Usuario")
                        .WithMany("AnalistaQAs")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Desenvolvedor", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.Usuario", "Usuario")
                        .WithMany("Desenvolvedores")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Metodologia", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.Usuario", "Usuario")
                        .WithMany("Metodologias")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.PlanoDeTeste", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Projeto", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.Usuario", "Usuario")
                        .WithMany("Projetos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Step", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany()
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sonnar.Domain.Models.Metodologia", "Metodologia")
                        .WithMany()
                        .HasForeignKey("MetodologiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sonnar.Domain.Models.Teste", "Teste")
                        .WithMany()
                        .HasForeignKey("TesteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");

                    b.Navigation("Metodologia");

                    b.Navigation("Teste");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Teste", b =>
                {
                    b.HasOne("Sonnar.Domain.Models.AnalistaQA", "AnalistaQA")
                        .WithMany()
                        .HasForeignKey("AnalistaQAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sonnar.Domain.Models.PlanoDeTeste", "PlanoDeTeste")
                        .WithMany()
                        .HasForeignKey("PlanoDeTesteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sonnar.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sonnar.Domain.Models.Teste", null)
                        .WithMany("Testes")
                        .HasForeignKey("TesteId");

                    b.HasOne("Sonnar.Domain.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnalistaQA");

                    b.Navigation("PlanoDeTeste");

                    b.Navigation("Projeto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Teste", b =>
                {
                    b.Navigation("Testes");
                });

            modelBuilder.Entity("Sonnar.Domain.Models.Usuario", b =>
                {
                    b.Navigation("AnalistaQAs");

                    b.Navigation("Desenvolvedores");

                    b.Navigation("Metodologias");

                    b.Navigation("Projetos");
                });
#pragma warning restore 612, 618
        }
    }
}
