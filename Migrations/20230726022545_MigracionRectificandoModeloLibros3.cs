using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionRectificandoModeloLibros3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("64bd2418-5895-4dba-bf45-66913e8a1b55"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("903870cc-b2a9-4209-91cd-3db5c7e75524"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("9eefa308-1d93-4d05-a667-cfd235cbe567"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("d560e178-fa55-4384-8436-a927d8ef1a70"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("e5b5ccd8-750d-4629-82a5-28d634ff9049"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("edf1e5e2-013f-4865-a558-b39cde8d9c4b"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("3740aa8b-7d79-4605-b5f3-7781b18489cf"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("1e62aecd-5580-4b98-a9c4-0c95f3a0b4bc"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1e62aecd-5580-4b98-a9c4-0c95f3a0b4bc"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2598), "Novela Policiaca", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2602) },
                    { new Guid("64bd2418-5895-4dba-bf45-66913e8a1b55"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2624), "Poesía", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2625) },
                    { new Guid("903870cc-b2a9-4209-91cd-3db5c7e75524"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2615), "Romántico", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2615) },
                    { new Guid("9eefa308-1d93-4d05-a667-cfd235cbe567"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2619), "Ficción", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2619) },
                    { new Guid("d560e178-fa55-4384-8436-a927d8ef1a70"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2622), "Ensayo", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2623) },
                    { new Guid("e5b5ccd8-750d-4629-82a5-28d634ff9049"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2621), "Biografía", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2621) },
                    { new Guid("edf1e5e2-013f-4865-a558-b39cde8d9c4b"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2617), "Erótico", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2617) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[] { new Guid("3740aa8b-7d79-4605-b5f3-7781b18489cf"), new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2848), false, new Guid("1e62aecd-5580-4b98-a9c4-0c95f3a0b4bc"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 2, 18, 28, 923, DateTimeKind.Utc).AddTicks(2849) });
        }
    }
}
