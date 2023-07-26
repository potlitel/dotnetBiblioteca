using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionRectificandoModeloLibros1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "GeneroId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { new Guid("33d26902-e574-4db6-931a-83f69cb5c81d"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9605), "Erótico", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9606) },
                    { new Guid("65d8f621-2b88-4a3b-ae8f-0a5e60eb7be3"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9611), "Ensayo", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9611) },
                    { new Guid("6ddf7352-d6d2-47a4-af93-4791db7a18e1"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9603), "Romántico", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9604) },
                    { new Guid("9373e19d-2f9e-42ef-a0f8-65a027af56ec"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9609), "Biografía", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9609) },
                    { new Guid("a43c1937-244d-431f-afc8-c7f760bc6f63"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9624), "Poesía", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9625) },
                    { new Guid("b4970da9-1487-449b-a716-4b0a5c136814"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9607), "Ficción", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9607) },
                    { new Guid("f82b3f51-abed-4342-b225-5db95c2d2c3a"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9598), "Novela Policiaca", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9601) }
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "LibroId", "created_at", "Estado", "GeneroId", "ISBN", "Nombre", "updated_at" },
                values: new object[] { new Guid("b03565f8-a06f-4ea4-8fda-24eba7ac4ed4"), new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9790), false, new Guid("f82b3f51-abed-4342-b225-5db95c2d2c3a"), "978-84-8136-542-9", "Una pica en Flandes", new DateTime(2023, 7, 26, 2, 5, 45, 612, DateTimeKind.Utc).AddTicks(9790) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("33d26902-e574-4db6-931a-83f69cb5c81d"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("65d8f621-2b88-4a3b-ae8f-0a5e60eb7be3"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("6ddf7352-d6d2-47a4-af93-4791db7a18e1"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("9373e19d-2f9e-42ef-a0f8-65a027af56ec"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("a43c1937-244d-431f-afc8-c7f760bc6f63"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("b4970da9-1487-449b-a716-4b0a5c136814"));

            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "LibroId",
                keyValue: new Guid("b03565f8-a06f-4ea4-8fda-24eba7ac4ed4"));

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "GeneroId",
                keyValue: new Guid("f82b3f51-abed-4342-b225-5db95c2d2c3a"));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "libros",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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
    }
}
