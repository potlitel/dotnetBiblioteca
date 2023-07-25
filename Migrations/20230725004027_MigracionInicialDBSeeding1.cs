using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicialDBSeeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("7f23c6d3-af51-438c-afc7-c317cb0a5040"));

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[] { new Guid("0f325eda-5da1-4728-adf6-c5256fb5feb6"), new DateTime(2023, 7, 25, 0, 40, 27, 29, DateTimeKind.Utc).AddTicks(4891), "William", new DateTime(2023, 7, 25, 0, 40, 27, 29, DateTimeKind.Utc).AddTicks(4894) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("0f325eda-5da1-4728-adf6-c5256fb5feb6"));

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[] { new Guid("7f23c6d3-af51-438c-afc7-c317cb0a5040"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
