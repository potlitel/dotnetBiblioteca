using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeedingDBLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("2ea1be00-f227-4aee-9406-ba5aa2ac2d18"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("83723062-8751-4bf9-beb3-c9fa3f4f7507"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("8ae6c609-0b40-4ceb-be47-f264e1f36a80"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("a3f5e20e-6ce9-4e36-9f8a-e671ed544c12"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("aafe2f03-f019-41a2-b761-e2b124ca0c33"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("e6917963-a823-4e33-8f8a-43d28373543e"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("f17153fd-74a8-4cc4-996e-c53ce333155a"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("e0012fce-464e-49a9-b7f8-ba529e963c83"));

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("3c4f3f01-5d1f-46c6-afc9-e86ec1f16f11"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3515), "Romántico", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3516) },
                    { new Guid("6915bccb-b629-46da-86fb-e5a7bc2965a2"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3525), "Biografía", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3526) },
                    { new Guid("75ed4fd8-a0fb-42a7-b4b2-18cb6579dc01"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3542), "Ensayo", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3543) },
                    { new Guid("77d4de25-2666-439e-8463-87923582d4c6"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3507), "Novela Policiaca", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3512) },
                    { new Guid("b21fe479-2f74-44e9-a5b9-3895a74c2709"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3522), "Ficción", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3523) },
                    { new Guid("c0f309ff-f2c6-4949-8ec3-9cbcac22d6df"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3545), "Poesía", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3546) },
                    { new Guid("f28f7afb-8767-40ec-9170-8c6213cebfd4"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3519), "Erótico", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3519) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("058c0f62-779e-4c4a-b029-f279f6dbcbac"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3912), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-7884-370-1", "De la Habana ha llegado", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3913) },
                    { new Guid("6eed1c6b-ecba-4e6c-94a6-bb755733a186"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3877), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3878) },
                    { new Guid("869f88e8-d7fb-4a59-9568-a00cbbd0a4f1"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3885), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-15313-59-5", "Adiós muchachos", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3885) },
                    { new Guid("8fbd8b34-9213-4538-9740-ded0249666bf"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3909), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-96546-19-6", "LO QUE DURA DURA", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3909) },
                    { new Guid("9a214f85-686e-4f6f-a9e4-f1236507f5bf"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3915), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-959-218-103-8", "El aguacate y la virtud", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3916) },
                    { new Guid("b029f7a9-17bd-43bc-b68d-0e8c24c9d00a"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3894), true, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-7884-500-2", "Aquel año en Madrid", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3895) },
                    { new Guid("bfbce380-a021-4c07-b3a9-9027d65e5123"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3881), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-15313-05-2", "Allá ellos", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3882) },
                    { new Guid("cd71826b-ec7c-4238-a5c8-69cfb2df2868"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3903), true, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-956-366-003-6", "El último room service", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3903) },
                    { new Guid("db39d0fb-5015-46e6-b51f-1f62cfe3927b"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3906), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-8136-572-6", "Príapos", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3906) },
                    { new Guid("f7d48eb7-cca9-47c8-8c8a-225b7590614a"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3888), false, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-7884-546-0", "Juguete nuevo", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3889) },
                    { new Guid("ff2aa345-9734-4575-be41-c3641810c3ee"), new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3891), true, new Guid("77d4de25-2666-439e-8463-87923582d4c6"), "978-84-16350-14-8", "Raúl Sendic", new DateTime(2023, 7, 26, 2, 35, 11, 231, DateTimeKind.Utc).AddTicks(3892) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("3c4f3f01-5d1f-46c6-afc9-e86ec1f16f11"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("6915bccb-b629-46da-86fb-e5a7bc2965a2"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("75ed4fd8-a0fb-42a7-b4b2-18cb6579dc01"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("b21fe479-2f74-44e9-a5b9-3895a74c2709"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("c0f309ff-f2c6-4949-8ec3-9cbcac22d6df"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("f28f7afb-8767-40ec-9170-8c6213cebfd4"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("058c0f62-779e-4c4a-b029-f279f6dbcbac"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("6eed1c6b-ecba-4e6c-94a6-bb755733a186"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("869f88e8-d7fb-4a59-9568-a00cbbd0a4f1"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("8fbd8b34-9213-4538-9740-ded0249666bf"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("9a214f85-686e-4f6f-a9e4-f1236507f5bf"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("b029f7a9-17bd-43bc-b68d-0e8c24c9d00a"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("bfbce380-a021-4c07-b3a9-9027d65e5123"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("cd71826b-ec7c-4238-a5c8-69cfb2df2868"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("db39d0fb-5015-46e6-b51f-1f62cfe3927b"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("f7d48eb7-cca9-47c8-8c8a-225b7590614a"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("ff2aa345-9734-4575-be41-c3641810c3ee"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("77d4de25-2666-439e-8463-87923582d4c6"));

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("2ea1be00-f227-4aee-9406-ba5aa2ac2d18"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1929), "Poesía", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1929) },
                    { new Guid("83723062-8751-4bf9-beb3-c9fa3f4f7507"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1919), "Erótico", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1919) },
                    { new Guid("8ae6c609-0b40-4ceb-be47-f264e1f36a80"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1921), "Ficción", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1922) },
                    { new Guid("a3f5e20e-6ce9-4e36-9f8a-e671ed544c12"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1924), "Biografía", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1925) },
                    { new Guid("aafe2f03-f019-41a2-b761-e2b124ca0c33"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1926), "Ensayo", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1927) },
                    { new Guid("e0012fce-464e-49a9-b7f8-ba529e963c83"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1893), "Novela Policiaca", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1898) },
                    { new Guid("e6917963-a823-4e33-8f8a-43d28373543e"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1916), "Romántico", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(1916) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[] { new Guid("f17153fd-74a8-4cc4-996e-c53ce333155a"), new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(2411), false, new Guid("e0012fce-464e-49a9-b7f8-ba529e963c83"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 2, 25, 45, 747, DateTimeKind.Utc).AddTicks(2412) });
        }
    }
}
