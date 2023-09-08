using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionPrestamoModelDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLibro = table.Column<int>(type: "int", nullable: false),
                    LibroIdBook = table.Column<int>(type: "int", nullable: true),
                    IdLector = table.Column<int>(type: "int", nullable: false),
                    LectorIdLector = table.Column<int>(type: "int", nullable: true),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prestamos_lector_LectorIdLector",
                        column: x => x.LectorIdLector,
                        principalTable: "lector",
                        principalColumn: "IdLector");
                    table.ForeignKey(
                        name: "FK_prestamos_libros_LibroIdBook",
                        column: x => x.LibroIdBook,
                        principalTable: "libros",
                        principalColumn: "IdBook");
                });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(6674), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8381), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8382), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8384), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8385), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8386), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8388), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8389), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8392), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8393), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8394), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8396), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8397), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8398), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8401), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8403), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8404), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8405), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8407), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8408), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8409), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8411), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8412), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8413), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8414), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8416), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8417), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8418), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8420), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8421), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8423), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8424), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8426), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8427), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8585), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8588), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8590), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8592), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8594), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8595), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8597), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8608), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8612), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8615), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8617), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8619), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8622), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8624), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8626), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8627), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8629), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8631), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8633), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8634), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8636), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8638), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8547), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8550), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8551), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8553), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8555), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8556), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8561), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8563), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8564), new DateTime(2023, 9, 8, 22, 30, 55, 242, DateTimeKind.Utc).AddTicks(8565) });

            migrationBuilder.InsertData(
                table: "prestamos",
                columns: new[] { "Id", "created_at", "IdLector", "IdLibro", "LectorIdLector", "LibroIdBook", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 6, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LectorIdLector",
                table: "prestamos",
                column: "LectorIdLector");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LibroIdBook",
                table: "prestamos",
                column: "LibroIdBook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prestamos");

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(2624), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4684), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4687), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4688), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4690), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4691), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4692), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4694), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4695), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4696), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4698), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4699), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4700), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4701), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4703), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4704), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4706), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4707), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4709), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4710), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4711), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4713), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4714), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4716), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4717), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4718), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4719), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4720), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4722), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4723), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4724), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4725), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4726), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4728), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4729), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4915), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4917), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4920), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4922), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4924), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4925), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4927), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4929), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4931), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4933), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4934), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4936), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4938), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4940), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4942), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4944), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4945), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4947), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4949), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4951), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4953), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4954), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4956), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4958), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4959), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4875), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4878), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4880), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4882), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4884), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4886), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4887), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4890), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4891), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4893), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4894), new DateTime(2023, 9, 8, 22, 14, 27, 560, DateTimeKind.Utc).AddTicks(4895) });
        }
    }
}
