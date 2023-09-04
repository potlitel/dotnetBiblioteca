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
    [Migration("20230904015532_MigracionDBSeedGeneros")]
    partial class MigracionDBSeedGeneros
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
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 180, DateTimeKind.Utc).AddTicks(9730),
                            Nombre = "Novela Policiaca",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 180, DateTimeKind.Utc).AddTicks(9732)
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1613),
                            Nombre = "Romántico",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1614)
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1615),
                            Nombre = "Erótico",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1615)
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1616),
                            Nombre = "Ficción",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1617)
                        },
                        new
                        {
                            CategoryId = 5,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1618),
                            Nombre = "Biografía",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1618)
                        },
                        new
                        {
                            CategoryId = 6,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1619),
                            Nombre = "Ensayo",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1619)
                        },
                        new
                        {
                            CategoryId = 7,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1620),
                            Nombre = "Poesía",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1621)
                        },
                        new
                        {
                            CategoryId = 8,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1621),
                            Nombre = "Clásicos Literarios",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1622)
                        },
                        new
                        {
                            CategoryId = 9,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1623),
                            Nombre = "Cómic y Libros Ilustrados",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1623)
                        },
                        new
                        {
                            CategoryId = 10,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1624),
                            Nombre = "Cuentos y Relatos",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1624)
                        },
                        new
                        {
                            CategoryId = 11,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1625),
                            Nombre = "Fantasía",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1626)
                        },
                        new
                        {
                            CategoryId = 12,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1627),
                            Nombre = "Humor",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1627)
                        },
                        new
                        {
                            CategoryId = 13,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1628),
                            Nombre = "Infantil",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1628)
                        },
                        new
                        {
                            CategoryId = 14,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1629),
                            Nombre = "Juvenil",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1629)
                        },
                        new
                        {
                            CategoryId = 15,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1630),
                            Nombre = "Novela Histórica",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1631)
                        },
                        new
                        {
                            CategoryId = 16,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1632),
                            Nombre = "Novela Negra y Policiaca",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1632)
                        },
                        new
                        {
                            CategoryId = 17,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1633),
                            Nombre = "Novela Romántica",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1634)
                        },
                        new
                        {
                            CategoryId = 18,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1635),
                            Nombre = "Terror y Thriller",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1635)
                        },
                        new
                        {
                            CategoryId = 19,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1636),
                            Nombre = "Arte",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1636)
                        },
                        new
                        {
                            CategoryId = 20,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1637),
                            Nombre = "Autoayuda",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1638)
                        },
                        new
                        {
                            CategoryId = 21,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1639),
                            Nombre = "Biografías y Autobiografías",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1639)
                        },
                        new
                        {
                            CategoryId = 22,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1640),
                            Nombre = "Cocina y Gastronomía",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1640)
                        },
                        new
                        {
                            CategoryId = 23,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1641),
                            Nombre = "Deportes",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1642)
                        },
                        new
                        {
                            CategoryId = 24,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1642),
                            Nombre = "Divulgación Científica",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1643)
                        },
                        new
                        {
                            CategoryId = 25,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1644),
                            Nombre = "Enciclopedias y Diccionarios",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1644)
                        },
                        new
                        {
                            CategoryId = 26,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1645),
                            Nombre = "Filosofía",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1645)
                        },
                        new
                        {
                            CategoryId = 27,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1646),
                            Nombre = "Historia",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1647)
                        },
                        new
                        {
                            CategoryId = 28,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1647),
                            Nombre = "Idiomas",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1648)
                        },
                        new
                        {
                            CategoryId = 29,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1649),
                            Nombre = "Libros de Texto",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1649)
                        },
                        new
                        {
                            CategoryId = 30,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1650),
                            Nombre = "Libros Técnicos",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1650)
                        },
                        new
                        {
                            CategoryId = 31,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1651),
                            Nombre = "Madres y Padres",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1652)
                        },
                        new
                        {
                            CategoryId = 32,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1652),
                            Nombre = "Negocios e Inversiones",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1653)
                        },
                        new
                        {
                            CategoryId = 33,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1654),
                            Nombre = "Religión",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1654)
                        },
                        new
                        {
                            CategoryId = 34,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1655),
                            Nombre = "Viajes",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1655)
                        },
                        new
                        {
                            CategoryId = 35,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1656),
                            Nombre = "Teatro y Dramático",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1657)
                        },
                        new
                        {
                            CategoryId = 36,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1657),
                            Nombre = "Lírico",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1658)
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
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1839),
                            Estado = false,
                            ISBN = "978-84-8136-542-9",
                            Nombre = "Una pica en Flandes",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1839)
                        },
                        new
                        {
                            IdBook = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1841),
                            Estado = false,
                            ISBN = "978-84-15313-05-2",
                            Nombre = "Allá ellos",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1842)
                        },
                        new
                        {
                            IdBook = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1843),
                            Estado = false,
                            ISBN = "978-84-15313-59-5",
                            Nombre = "Adiós muchachos",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1844)
                        },
                        new
                        {
                            IdBook = 4,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1845),
                            Estado = false,
                            ISBN = "978-84-7884-546-0",
                            Nombre = "Juguete nuevo",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1846)
                        },
                        new
                        {
                            IdBook = 5,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1847),
                            Estado = true,
                            ISBN = "978-84-16350-14-8",
                            Nombre = "Raúl Sendic",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1847)
                        },
                        new
                        {
                            IdBook = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1848),
                            Estado = true,
                            ISBN = "978-84-7884-500-2",
                            Nombre = "Aquel año en Madrid",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1849)
                        },
                        new
                        {
                            IdBook = 7,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1850),
                            Estado = true,
                            ISBN = "978-956-366-003-6",
                            Nombre = "El último room service",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1850)
                        },
                        new
                        {
                            IdBook = 8,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1851),
                            Estado = false,
                            ISBN = "978-84-8136-572-6",
                            Nombre = "Príapos",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1852)
                        },
                        new
                        {
                            IdBook = 9,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1853),
                            Estado = false,
                            ISBN = "978-84-96546-19-6",
                            Nombre = "LO QUE DURA DURA",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1853)
                        },
                        new
                        {
                            IdBook = 10,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1855),
                            Estado = false,
                            ISBN = "978-84-7884-370-1",
                            Nombre = "De la Habana ha llegado",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1855)
                        },
                        new
                        {
                            IdBook = 11,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1857),
                            Estado = false,
                            ISBN = "978-959-218-103-8",
                            Nombre = "El aguacate y la virtud",
                            UpdatedAt = new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1857)
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
