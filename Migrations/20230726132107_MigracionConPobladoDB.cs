using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionConPobladoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6377), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6452), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6454), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6456), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6457), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6458), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6459), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "IdBook", "CategoryId", "created_at", "Estado", "ISBN", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6616), false, "978-84-15313-05-2", "Allá ellos", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6617) },
                    { 3, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6619), false, "978-84-15313-59-5", "Adiós muchachos", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6619) },
                    { 4, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6622), false, "978-84-7884-546-0", "Juguete nuevo", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6622) },
                    { 5, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6623), true, "978-84-16350-14-8", "Raúl Sendic", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6624) },
                    { 6, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6626), true, "978-84-7884-500-2", "Aquel año en Madrid", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6626) },
                    { 7, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6628), true, "978-956-366-003-6", "El último room service", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6628) },
                    { 8, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6630), false, "978-84-8136-572-6", "Príapos", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6630) },
                    { 9, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6631), false, "978-84-96546-19-6", "LO QUE DURA DURA", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6632) },
                    { 10, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6633), false, "978-84-7884-370-1", "De la Habana ha llegado", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6633) },
                    { 11, 1, new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6635), false, "978-959-218-103-8", "El aguacate y la virtud", new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6635) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9192), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9273), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9276), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9278), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9279), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9281), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9442), new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9442) });
        }
    }
}
