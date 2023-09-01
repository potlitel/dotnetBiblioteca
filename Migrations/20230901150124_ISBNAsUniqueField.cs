using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class ISBNAsUniqueField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 83, DateTimeKind.Utc).AddTicks(8446), new DateTime(2023, 9, 1, 15, 1, 24, 83, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(602), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(604), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(605), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(607), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(608), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(609), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(752), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(757), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(759), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.CreateIndex(
                name: "IX_libros_ISBN",
                table: "libros",
                column: "ISBN",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_libros_ISBN",
                table: "libros");

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

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6616), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6619), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6622), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6628), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6631), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6633), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6635), new DateTime(2023, 7, 26, 13, 21, 7, 708, DateTimeKind.Utc).AddTicks(6635) });
        }
    }
}
