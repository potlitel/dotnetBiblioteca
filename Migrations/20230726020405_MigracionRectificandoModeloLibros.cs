using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionRectificandoModeloLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("ff92b0d3-d685-45f8-add2-a818a3191b3b"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("3ed4ab34-b7c6-4c35-9755-f513112fde35"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("d59060ef-8854-45b3-95cc-5101660a29ce"));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "libros",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("23443987-d932-4a5e-b473-1bc7f87f03b6"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(332), "Poesía", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(332) },
                    { new Guid("31a19d9f-95df-4867-bffd-a407d4de6d24"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(301), "Novela Policiaca", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(306) },
                    { new Guid("4cebb78c-b069-4f7c-89bf-a2a877e1740e"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(316), "Biografía", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(316) },
                    { new Guid("535689b7-f0e1-479b-b791-524a208b83f9"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(312), "Erótico", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(312) },
                    { new Guid("c59c8008-558e-4d8c-a87b-fa18e38f7905"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(317), "Ensayo", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(318) },
                    { new Guid("e0158c04-54ab-4859-a3c6-30c7a5327072"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(314), "Ficción", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(314) },
                    { new Guid("ff5aa825-51f0-4012-b94a-d611094a5d4e"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(310), "Romántico", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(310) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[] { new Guid("2b84d503-02b1-40d1-8eb2-b81ee79402f8"), new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(582), false, new Guid("31a19d9f-95df-4867-bffd-a407d4de6d24"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 2, 4, 5, 460, DateTimeKind.Utc).AddTicks(583) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("23443987-d932-4a5e-b473-1bc7f87f03b6"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("4cebb78c-b069-4f7c-89bf-a2a877e1740e"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("535689b7-f0e1-479b-b791-524a208b83f9"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("c59c8008-558e-4d8c-a87b-fa18e38f7905"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("e0158c04-54ab-4859-a3c6-30c7a5327072"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("ff5aa825-51f0-4012-b94a-d611094a5d4e"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("2b84d503-02b1-40d1-8eb2-b81ee79402f8"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("31a19d9f-95df-4867-bffd-a407d4de6d24"));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "libros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

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
        }
    }
}
