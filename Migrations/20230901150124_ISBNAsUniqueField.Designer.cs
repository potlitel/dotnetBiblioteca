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
    [Migration("20230901150124_ISBNAsUniqueField")]
    partial class ISBNAsUniqueField
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
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

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

                    b.HasKey("CategoryId");

                    b.ToTable("generos");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 83, DateTimeKind.Utc).AddTicks(8446),
                            Nombre = "Novela Policiaca",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 83, DateTimeKind.Utc).AddTicks(8448)
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(602),
                            Nombre = "Romántico",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(603)
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(604),
                            Nombre = "Erótico",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(604)
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(605),
                            Nombre = "Ficción",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(606)
                        },
                        new
                        {
                            CategoryId = 5,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(607),
                            Nombre = "Biografía",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(607)
                        },
                        new
                        {
                            CategoryId = 6,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(608),
                            Nombre = "Ensayo",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(608)
                        },
                        new
                        {
                            CategoryId = 7,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(609),
                            Nombre = "Poesía",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(610)
                        });
                });

            modelBuilder.Entity("BootstrapDashboard.Models.Libro", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBook"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

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

                    b.HasKey("IdBook");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ISBN")
                        .IsUnique();

                    b.ToTable("libros");

                    b.HasData(
                        new
                        {
                            IdBook = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(744),
                            Estado = false,
                            ISBN = "978-84-8136-542-9",
                            Nombre = "Una pica en Flandes",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(745)
                        },
                        new
                        {
                            IdBook = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(746),
                            Estado = false,
                            ISBN = "978-84-15313-05-2",
                            Nombre = "Allá ellos",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(747)
                        },
                        new
                        {
                            IdBook = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(748),
                            Estado = false,
                            ISBN = "978-84-15313-59-5",
                            Nombre = "Adiós muchachos",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(749)
                        },
                        new
                        {
                            IdBook = 4,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(750),
                            Estado = false,
                            ISBN = "978-84-7884-546-0",
                            Nombre = "Juguete nuevo",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(751)
                        },
                        new
                        {
                            IdBook = 5,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(752),
                            Estado = true,
                            ISBN = "978-84-16350-14-8",
                            Nombre = "Raúl Sendic",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(752)
                        },
                        new
                        {
                            IdBook = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(754),
                            Estado = true,
                            ISBN = "978-84-7884-500-2",
                            Nombre = "Aquel año en Madrid",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(754)
                        },
                        new
                        {
                            IdBook = 7,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(755),
                            Estado = true,
                            ISBN = "978-956-366-003-6",
                            Nombre = "El último room service",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(756)
                        },
                        new
                        {
                            IdBook = 8,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(757),
                            Estado = false,
                            ISBN = "978-84-8136-572-6",
                            Nombre = "Príapos",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(758)
                        },
                        new
                        {
                            IdBook = 9,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(759),
                            Estado = false,
                            ISBN = "978-84-96546-19-6",
                            Nombre = "LO QUE DURA DURA",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(759)
                        },
                        new
                        {
                            IdBook = 10,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(761),
                            Estado = false,
                            ISBN = "978-84-7884-370-1",
                            Nombre = "De la Habana ha llegado",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(761)
                        },
                        new
                        {
                            IdBook = 11,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(762),
                            Estado = false,
                            ISBN = "978-959-218-103-8",
                            Nombre = "El aguacate y la virtud",
                            UpdatedAt = new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(763)
                        });
                });

            modelBuilder.Entity("BootstrapDashboard.Models.Libro", b =>
                {
                    b.HasOne("BootstrapDashboard.Models.Genero", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
