using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionPrestamoUniqueFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_prestamos_LibroId",
                table: "prestamos");

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(564), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5813), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5817), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5819), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5821), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5823), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5824), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5828), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5829), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5831), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5833), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5835), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5837), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5841), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5843), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5845), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5848), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5850), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5851), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5853), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5859), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5860), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5864), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5867), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5872), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5875), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5877), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6572), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6576), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6579), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6582), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6585), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6587), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6593), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6595), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6598), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6604), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6606), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6609), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6611), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6614), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6616), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6619), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6621), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6624), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6631), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6634), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6636), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6401), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6405), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6409), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6413), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6417), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6421), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6424), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6428), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6432), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6451), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6455), new DateTime(2023, 9, 10, 1, 42, 15, 455, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LibroId_LectorId",
                table: "prestamos",
                columns: new[] { "LibroId", "LectorId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_prestamos_LibroId_LectorId",
                table: "prestamos");

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(5766), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7557), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7559), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7562), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7567), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7568), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7571), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7575), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7590), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7593), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7594), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7596), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7597), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7598), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7600), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7601), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7765), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7767), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7769), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7771), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7773), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7774), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7776), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7778), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7780), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7783), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7785), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7787), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7789), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7791), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7792), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7794), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7796), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7797), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7799), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7801), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7803), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7805), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7848), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7850), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7722), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7724), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7726), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7728), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7729), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7731), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7733), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7734), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7737), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7738), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7740), new DateTime(2023, 9, 8, 22, 37, 12, 410, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LibroId",
                table: "prestamos",
                column: "LibroId");
        }
    }
}
