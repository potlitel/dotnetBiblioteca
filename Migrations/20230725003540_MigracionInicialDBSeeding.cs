using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicialDBSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.GeneroId);
                });

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[] { new Guid("7f23c6d3-af51-438c-afc7-c317cb0a5040"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "generos");
        }
    }
}
