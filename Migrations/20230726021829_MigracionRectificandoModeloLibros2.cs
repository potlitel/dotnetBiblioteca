using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionRectificandoModeloLibros2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("33d26902-e574-4db6-931a-83f69cb5c81d"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("65d8f621-2b88-4a3b-ae8f-0a5e60eb7be3"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("6ddf7352-d6d2-47a4-af93-4791db7a18e1"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("9373e19d-2f9e-42ef-a0f8-65a027af56ec"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("a43c1937-244d-431f-afc8-c7f760bc6f63"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("b4970da9-1487-449b-a716-4b0a5c136814"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("b03565f8-a06f-4ea4-8fda-24eba7ac4ed4"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("f82b3f51-abed-4342-b225-5db95c2d2c3a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("33d26902-e574-4db6-931a-83f69cb5c81d"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9605), "Erótico", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9606) },
                    { new Guid("65d8f621-2b88-4a3b-ae8f-0a5e60eb7be3"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9611), "Ensayo", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9611) },
                    { new Guid("6ddf7352-d6d2-47a4-af93-4791db7a18e1"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9603), "Romántico", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9604) },
                    { new Guid("9373e19d-2f9e-42ef-a0f8-65a027af56ec"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9609), "Biografía", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9609) },
                    { new Guid("a43c1937-244d-431f-afc8-c7f760bc6f63"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9624), "Poesía", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9625) },
                    { new Guid("b4970da9-1487-449b-a716-4b0a5c136814"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9607), "Ficción", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9607) },
                    { new Guid("f82b3f51-abed-4342-b225-5db95c2d2c3a"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9598), "Novela Policiaca", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9601) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[] { new Guid("b03565f8-a06f-4ea4-8fda-24eba7ac4ed4"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9790), false, new Guid("f82b3f51-abed-4342-b225-5db95c2d2c3a"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9790) });
        }
    }
}
