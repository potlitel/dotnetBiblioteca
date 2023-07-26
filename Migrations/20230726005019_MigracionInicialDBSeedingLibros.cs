using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicialDBSeedingLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    LibroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.LibroId);
                    table.ForeignKey(
                        name: "FK_libros_generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("0cffba3d-0b46-47a2-8568-7d7dc12ea473"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9474), "Romántico", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9475) },
                    { new Guid("12397790-6f97-4012-89a2-82338ae2fb02"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9496), "Ensayo", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9496) },
                    { new Guid("2bae1d8f-049f-4b94-a17d-b7fbe78039c3"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9493), "Biografía", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9494) },
                    { new Guid("48af7bf1-e086-49ce-bf0c-2e1ca70fdaaa"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9498), "Poesía", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9499) },
                    { new Guid("8b9aa3a5-95ee-4f51-9178-41bcd8feff50"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9477), "Erótico", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9477) },
                    { new Guid("d59060ef-8854-45b3-95cc-5101660a29ce"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9468), "Novela Policiaca", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9471) },
                    { new Guid("ff92b0d3-d685-45f8-add2-a818a3191b3b"), new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9491), "Ficción", new DateTime(2023, 7, 26, 0, 50, 19, 719, DateTimeKind.Utc).AddTicks(9491) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[] { new Guid("3ed4ab34-b7c6-4c35-9755-f513112fde35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("d59060ef-8854-45b3-95cc-5101660a29ce"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_libros_GeneroId",
                table: "libros",
                column: "GeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libros");

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("0cffba3d-0b46-47a2-8568-7d7dc12ea473"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("12397790-6f97-4012-89a2-82338ae2fb02"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("2bae1d8f-049f-4b94-a17d-b7fbe78039c3"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("48af7bf1-e086-49ce-bf0c-2e1ca70fdaaa"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("8b9aa3a5-95ee-4f51-9178-41bcd8feff50"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("d59060ef-8854-45b3-95cc-5101660a29ce"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("ff92b0d3-d685-45f8-add2-a818a3191b3b"));

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
    }
}
