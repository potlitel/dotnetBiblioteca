using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    IdBook = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.IdBook);
                    table.ForeignKey(
                        name: "FK_libros_generos_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "generos",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "CategoryId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9192), "Novela Policiaca", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9195) },
                    { 2, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9273), "Romántico", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9274) },
                    { 3, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9275), "Erótico", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9275) },
                    { 4, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9276), "Ficción", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9277) },
                    { 5, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9278), "Biografía", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9278) },
                    { 6, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9279), "Ensayo", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9279) },
                    { 7, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9281), "Poesía", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9282) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "IdBook", "CategoryId", "created_at", "Estado", "ISBN", "Nombre", "updated_at" },
                values: new object[] { 1, 1, new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9442), false, "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 12, 59, 35, 920, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.CreateIndex(
                name: "IX_libros_CategoryId",
                table: "libros",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libros");

            migrationBuilder.DropTable(
                name: "generos");
        }
    }
}
