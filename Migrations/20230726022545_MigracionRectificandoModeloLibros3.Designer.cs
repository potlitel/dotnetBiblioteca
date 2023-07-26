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
    [Migration("20230726022545_MigracionRectificandoModeloLibros3")]
    partial class MigracionRectificandoModeloLibros3
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
                            Id = new Guid("e0012fce-464e-49a9-b7f8-ba529e963c83"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1893),
                            Nombre = "Novela Policiaca",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1898)
                        },
                        new
                        {
                            Id = new Guid("e6917963-a823-4e33-8f8a-43d28373543e"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1916),
                            Nombre = "Romántico",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1916)
                        },
                        new
                        {
                            Id = new Guid("83723062-8751-4bf9-beb3-c9fa3f4f7507"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1919),
                            Nombre = "Erótico",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1919)
                        },
                        new
                        {
                            Id = new Guid("8ae6c609-0b40-4ceb-be47-f264e1f36a80"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1921),
                            Nombre = "Ficción",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1922)
                        },
                        new
                        {
                            Id = new Guid("a3f5e20e-6ce9-4e36-9f8a-e671ed544c12"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1924),
                            Nombre = "Biografía",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1925)
                        },
                        new
                        {
                            Id = new Guid("aafe2f03-f019-41a2-b761-e2b124ca0c33"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1926),
                            Nombre = "Ensayo",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1927)
                        },
                        new
                        {
                            Id = new Guid("2ea1be00-f227-4aee-9406-ba5aa2ac2d18"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1929),
                            Nombre = "Poesía",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1929)
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
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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
                            Id = new Guid("f17153fd-74a8-4cc4-996e-c53ce333155a"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(2411),
                            Estado = false,
                            GeneroId = new Guid("e0012fce-464e-49a9-b7f8-ba529e963c83"),
                            ISBN = "978-84-8136-542-9",
                            Nombre = "Una pica en Flandes",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(2412)
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
