using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionPrestamoModelDataSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_lector_LectorIdLector",
                table: "prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_libros_LibroIdBook",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_LectorIdLector",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_LibroIdBook",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "LectorIdLector",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "LibroIdBook",
                table: "prestamos");

            migrationBuilder.RenameColumn(
                name: "IdLibro",
                table: "prestamos",
                newName: "LibroId");

            migrationBuilder.RenameColumn(
                name: "IdLector",
                table: "prestamos",
                newName: "LectorId");

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
                name: "IX_prestamos_LectorId",
                table: "prestamos",
                column: "LectorId");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LibroId",
                table: "prestamos",
                column: "LibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_lector_LectorId",
                table: "prestamos",
                column: "LectorId",
                principalTable: "lector",
                principalColumn: "IdLector",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_libros_LibroId",
                table: "prestamos",
                column: "LibroId",
                principalTable: "libros",
                principalColumn: "IdBook",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_lector_LectorId",
                table: "prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_libros_LibroId",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_LectorId",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_LibroId",
                table: "prestamos");

            migrationBuilder.RenameColumn(
                name: "LibroId",
                table: "prestamos",
                newName: "IdLibro");

            migrationBuilder.RenameColumn(
                name: "LectorId",
                table: "prestamos",
                newName: "IdLector");

            migrationBuilder.AddColumn<int>(
                name: "LectorIdLector",
                table: "prestamos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibroIdBook",
                table: "prestamos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 209, DateTimeKind.Utc).AddTicks(8633), new DateTime(2023, 9, 8, 22, 32, 48, 209, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(401), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(406), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(407), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(408), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(411), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(412), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(414), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(415), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(416), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(417), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(419), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(421), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(423), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(424), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(425), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(427), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(428), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(429), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(431), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(432), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(433), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(435), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(436), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(437), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(439), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(441), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(443), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(444), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(445), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(447), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(603), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(606), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(608), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(610), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(612), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(614), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(616), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(715), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(718), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(720), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(722), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(724), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(725), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(727), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(730), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(732), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(733), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(735), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(737), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(739), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(742), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "lector",
                keyColumn: "IdLector",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(564), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(566), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(568), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(569), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(571), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(573), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(574), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(576), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(578), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(579), new DateTime(2023, 9, 8, 22, 32, 48, 210, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "prestamos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LectorIdLector", "LibroIdBook" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "prestamos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LectorIdLector", "LibroIdBook" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "prestamos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LectorIdLector", "LibroIdBook" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LectorIdLector",
                table: "prestamos",
                column: "LectorIdLector");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_LibroIdBook",
                table: "prestamos",
                column: "LibroIdBook");

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_lector_LectorIdLector",
                table: "prestamos",
                column: "LectorIdLector",
                principalTable: "lector",
                principalColumn: "IdLector");

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_libros_LibroIdBook",
                table: "prestamos",
                column: "LibroIdBook",
                principalTable: "libros",
                principalColumn: "IdBook");
        }
    }
}
