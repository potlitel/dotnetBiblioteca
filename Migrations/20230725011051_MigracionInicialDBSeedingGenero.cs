using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicialDBSeedingGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("0f325eda-5da1-4728-adf6-c5256fb5feb6"));

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("3eeb4c70-7b00-4100-a614-06b1226aad4d"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7684), "Novela Policiaca", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7689) },
                    { new Guid("55032df2-d022-4366-8c71-eb1edb0e1afd"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7696), "Ficción", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7697) },
                    { new Guid("621effe3-ff0f-4fce-8fe0-17c50225242e"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7712), "Poesía", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7712) },
                    { new Guid("66490248-4be0-4e75-aea5-ebad4543da34"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7698), "Biografía", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7699) },
                    { new Guid("738977c7-68ab-4874-a3fa-67938165ea55"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7710), "Ensayo", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7710) },
                    { new Guid("d365c33d-97bd-47f9-8dfc-c3b0c419601e"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7694), "Erótico", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7694) },
                    { new Guid("d805f947-3067-4c43-b9a7-61242a494147"), new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7691), "Romántico", new DateTime(2023, 7, 25, 1, 10, 51, 517, DateTimeKind.Utc).AddTicks(7692) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("3eeb4c70-7b00-4100-a614-06b1226aad4d"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("55032df2-d022-4366-8c71-eb1edb0e1afd"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("621effe3-ff0f-4fce-8fe0-17c50225242e"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("66490248-4be0-4e75-aea5-ebad4543da34"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("738977c7-68ab-4874-a3fa-67938165ea55"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("d365c33d-97bd-47f9-8dfc-c3b0c419601e"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("d805f947-3067-4c43-b9a7-61242a494147"));

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[] { new Guid("0f325eda-5da1-4728-adf6-c5256fb5feb6"), new DateTime(2023, 7, 25, 0, 40, 27, 29, DateTimeKind.Utc).AddTicks(4891), "William", new DateTime(2023, 7, 25, 0, 40, 27, 29, DateTimeKind.Utc).AddTicks(4894) });
        }
    }
}
