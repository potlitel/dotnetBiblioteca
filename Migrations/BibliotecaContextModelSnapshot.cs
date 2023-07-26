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
                            Id = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3507),
                            Nombre = "Novela Policiaca",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3512)
                        },
                        new
                        {
                            Id = new Guid("3c4f3f01-5d1f-46c6-afc9-e86ec1f16f11"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3515),
                            Nombre = "Romántico",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3516)
                        },
                        new
                        {
                            Id = new Guid("f28f7afb-8767-40ec-9170-8c6213cebfd4"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3519),
                            Nombre = "Erótico",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3519)
                        },
                        new
                        {
                            Id = new Guid("b21fe479-2f74-44e9-a5b9-3895a74c2709"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3522),
                            Nombre = "Ficción",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3523)
                        },
                        new
                        {
                            Id = new Guid("6915bccb-b629-46da-86fb-e5a7bc2965a2"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3525),
                            Nombre = "Biografía",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3526)
                        },
                        new
                        {
                            Id = new Guid("75ed4fd8-a0fb-42a7-b4b2-18cb6579dc01"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3542),
                            Nombre = "Ensayo",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3543)
                        },
                        new
                        {
                            Id = new Guid("c0f309ff-f2c6-4949-8ec3-9cbcac22d6df"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3545),
                            Nombre = "Poesía",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3546)
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
                            Id = new Guid("6eed1c6b-ecba-4e6c-94a6-bb755733a186"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3877),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-8136-542-9",
                            Nombre = "Una pica en Flandes",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3878)
                        },
                        new
                        {
                            Id = new Guid("bfbce380-a021-4c07-b3a9-9027d65e5123"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3881),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-15313-05-2",
                            Nombre = "Allá ellos",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3882)
                        },
                        new
                        {
                            Id = new Guid("869f88e8-d7fb-4a59-9568-a00cbbd0a4f1"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3885),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-15313-59-5",
                            Nombre = "Adiós muchachos",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3885)
                        },
                        new
                        {
                            Id = new Guid("f7d48eb7-cca9-47c8-8c8a-225b7590614a"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3888),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-7884-546-0",
                            Nombre = "Juguete nuevo",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3889)
                        },
                        new
                        {
                            Id = new Guid("ff2aa345-9734-4575-be41-c3641810c3ee"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3891),
                            Estado = true,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-16350-14-8",
                            Nombre = "Raúl Sendic",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3892)
                        },
                        new
                        {
                            Id = new Guid("b029f7a9-17bd-43bc-b68d-0e8c24c9d00a"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3894),
                            Estado = true,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-7884-500-2",
                            Nombre = "Aquel año en Madrid",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3895)
                        },
                        new
                        {
                            Id = new Guid("cd71826b-ec7c-4238-a5c8-69cfb2df2868"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3903),
                            Estado = true,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-956-366-003-6",
                            Nombre = "El último room service",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3903)
                        },
                        new
                        {
                            Id = new Guid("db39d0fb-5015-46e6-b51f-1f62cfe3927b"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3906),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-8136-572-6",
                            Nombre = "Príapos",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3906)
                        },
                        new
                        {
                            Id = new Guid("8fbd8b34-9213-4538-9740-ded0249666bf"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3909),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-96546-19-6",
                            Nombre = "LO QUE DURA DURA",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3909)
                        },
                        new
                        {
                            Id = new Guid("058c0f62-779e-4c4a-b029-f279f6dbcbac"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3912),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-84-7884-370-1",
                            Nombre = "De la Habana ha llegado",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3913)
                        },
                        new
                        {
                            Id = new Guid("9a214f85-686e-4f6f-a9e4-f1236507f5bf"),
                            CreatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3915),
                            Estado = false,
                            GeneroId = new Guid("77d4de25-2666-439e-8463-87923582d4c6"),
                            ISBN = "978-959-218-103-8",
                            Nombre = "El aguacate y la virtud",
                            UpdatedAt = new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3916)
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
