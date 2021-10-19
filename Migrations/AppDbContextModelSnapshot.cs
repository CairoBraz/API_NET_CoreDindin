﻿// <auto-generated />
using ApiDindin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiDindin.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("ApiDindin.Models.Aula", b =>
                {
                    b.Property<int>("AulaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoAula")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("LinkAula")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("TituloAula")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("AulaId");

                    b.ToTable("Aulas");

                    b.HasData(
                        new
                        {
                            AulaId = 1,
                            CursoId = 1,
                            DescricaoAula = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                            LinkAula = "www.aula.com",
                            TituloAula = "Aula 1"
                        },
                        new
                        {
                            AulaId = 2,
                            CursoId = 2,
                            DescricaoAula = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                            LinkAula = "www.aula.com",
                            TituloAula = "Aula 2"
                        },
                        new
                        {
                            AulaId = 3,
                            CursoId = 3,
                            DescricaoAula = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                            LinkAula = "www.aula.com",
                            TituloAula = "Aula 3"
                        });
                });

            modelBuilder.Entity("ApiDindin.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Professor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UploadCapa")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            Descricao = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                            Professor = "Marcos Santos",
                            Titulo = "Investimento para Iniciantes",
                            UploadCapa = "Capa teste1"
                        },
                        new
                        {
                            CursoId = 2,
                            Descricao = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                            Professor = "Luiz Carlos",
                            Titulo = "Poupando e Rendendo",
                            UploadCapa = "Capa teste2"
                        },
                        new
                        {
                            CursoId = 3,
                            Descricao = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                            Professor = "Regina Sanderberg",
                            Titulo = "Independência Financeira",
                            UploadCapa = "Capa teste3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}