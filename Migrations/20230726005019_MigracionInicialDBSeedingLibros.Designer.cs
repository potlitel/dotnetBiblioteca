﻿// <auto-generated />
using System;
using BootstrapDashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20230726005019_MigracionInicialDBSeedingLibros")]
    partial class MigracionInicialDBSeedingLibros
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BootstrapDashboard.Models.Genero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GeneroId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("generos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d59060ef-8854-45b3-95cc-5101660a29ce"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9468),
                            Nombre = "Novela Policiaca",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9471)
                        },
                        new
                        {
                            Id = new Guid("0cffba3d-0b46-47a2-8568-7d7dc12ea473"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9474),
                            Nombre = "Romántico",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9475)
                        },
                        new
                        {
                            Id = new Guid("8b9aa3a5-95ee-4f51-9178-41bcd8feff50"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9477),
                            Nombre = "Erótico",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9477)
                        },
                        new
                        {
                            Id = new Guid("ff92b0d3-d685-45f8-add2-a818a3191b3b"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9491),
                            Nombre = "Ficción",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9491)
                        },
                        new
                        {
                            Id = new Guid("2bae1d8f-049f-4b94-a17d-b7fbe78039c3"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9493),
                            Nombre = "Biografía",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9494)
                        },
                        new
                        {
                            Id = new Guid("12397790-6f97-4012-89a2-82338ae2fb02"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9496),
                            Nombre = "Ensayo",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9496)
                        },
                        new
                        {
                            Id = new Guid("48af7bf1-e086-49ce-bf0c-2e1ca70fdaaa"),
                            CreatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9498),
                            Nombre = "Poesía",
                            UpdatedAt = new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9499)
                        });
                });

            modelBuilder.Entity("BootstrapDashboard.Models.Libro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LibroId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<Guid>("GeneroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("libros");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3ed4ab34-b7c6-4c35-9755-f513112fde35"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = false,
                            GeneroId = new Guid("d59060ef-8854-45b3-95cc-5101660a29ce"),
                            ISBN = "978-84-8136-542-9",
                            Nombre = "Una pica en Flandes",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BootstrapDashboard.Models.Libro", b =>
                {
                    b.HasOne("BootstrapDashboard.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
