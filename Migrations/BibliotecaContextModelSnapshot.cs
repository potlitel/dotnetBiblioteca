﻿// <auto-generated />
using System;
using BootstrapDashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    partial class BibliotecaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6377),
                            Nombre = "Novela Policiaca",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6379)
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6452),
                            Nombre = "Romántico",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6453)
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6454),
                            Nombre = "Erótico",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6454)
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6456),
                            Nombre = "Ficción",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6456)
                        },
                        new
                        {
                            CategoryId = 5,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6457),
                            Nombre = "Biografía",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6457)
                        },
                        new
                        {
                            CategoryId = 6,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6458),
                            Nombre = "Ensayo",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6459)
                        },
                        new
                        {
                            CategoryId = 7,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6459),
                            Nombre = "Poesía",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6460)
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

                    b.ToTable("libros");

                    b.HasData(
                        new
                        {
                            IdBook = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6613),
                            Estado = false,
                            ISBN = "978-84-8136-542-9",
                            Nombre = "Una pica en Flandes",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6613)
                        },
                        new
                        {
                            IdBook = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6616),
                            Estado = false,
                            ISBN = "978-84-15313-05-2",
                            Nombre = "Allá ellos",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6617)
                        },
                        new
                        {
                            IdBook = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6619),
                            Estado = false,
                            ISBN = "978-84-15313-59-5",
                            Nombre = "Adiós muchachos",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6619)
                        },
                        new
                        {
                            IdBook = 4,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6622),
                            Estado = false,
                            ISBN = "978-84-7884-546-0",
                            Nombre = "Juguete nuevo",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6622)
                        },
                        new
                        {
                            IdBook = 5,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6623),
                            Estado = true,
                            ISBN = "978-84-16350-14-8",
                            Nombre = "Raúl Sendic",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6624)
                        },
                        new
                        {
                            IdBook = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6626),
                            Estado = true,
                            ISBN = "978-84-7884-500-2",
                            Nombre = "Aquel año en Madrid",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6626)
                        },
                        new
                        {
                            IdBook = 7,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6628),
                            Estado = true,
                            ISBN = "978-956-366-003-6",
                            Nombre = "El último room service",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6628)
                        },
                        new
                        {
                            IdBook = 8,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6630),
                            Estado = false,
                            ISBN = "978-84-8136-572-6",
                            Nombre = "Príapos",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6630)
                        },
                        new
                        {
                            IdBook = 9,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6631),
                            Estado = false,
                            ISBN = "978-84-96546-19-6",
                            Nombre = "LO QUE DURA DURA",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6632)
                        },
                        new
                        {
                            IdBook = 10,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6633),
                            Estado = false,
                            ISBN = "978-84-7884-370-1",
                            Nombre = "De la Habana ha llegado",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6633)
                        },
                        new
                        {
                            IdBook = 11,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6635),
                            Estado = false,
                            ISBN = "978-959-218-103-8",
                            Nombre = "El aguacate y la virtud",
                            UpdatedAt = new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6635)
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
