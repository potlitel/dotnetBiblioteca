using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionDBSeedGeneros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 180, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 9, 4, 1, 55, 32, 180, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1615), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1619), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.InsertData(
                table: "generos",
                columns: new[] { "CategoryId", "created_at", "Nombre", "updated_at" },
                values: new object[,]
                {
                    { 8, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1621), "Clásicos Literarios", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1622) },
                    { 9, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1623), "Cómic y Libros Ilustrados", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1623) },
                    { 10, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1624), "Cuentos y Relatos", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1624) },
                    { 11, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1625), "Fantasía", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1626) },
                    { 12, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1627), "Humor", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1627) },
                    { 13, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1628), "Infantil", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1628) },
                    { 14, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1629), "Juvenil", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1629) },
                    { 15, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1630), "Novela Histórica", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1631) },
                    { 16, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1632), "Novela Negra y Policiaca", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1632) },
                    { 17, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1633), "Novela Romántica", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1634) },
                    { 18, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1635), "Terror y Thriller", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1635) },
                    { 19, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1636), "Arte", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1636) },
                    { 20, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1637), "Autoayuda", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1638) },
                    { 21, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1639), "Biografías y Autobiografías", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1639) },
                    { 22, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1640), "Cocina y Gastronomía", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1640) },
                    { 23, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1641), "Deportes", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1642) },
                    { 24, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1642), "Divulgación Científica", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1643) },
                    { 25, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1644), "Enciclopedias y Diccionarios", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1644) },
                    { 26, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1645), "Filosofía", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1645) },
                    { 27, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1646), "Historia", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1647) },
                    { 28, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1647), "Idiomas", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1648) },
                    { 29, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1649), "Libros de Texto", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1649) },
                    { 30, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1650), "Libros Técnicos", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1650) },
                    { 31, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1651), "Madres y Padres", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1652) },
                    { 32, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1652), "Negocios e Inversiones", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1653) },
                    { 33, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1654), "Religión", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1654) },
                    { 34, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1655), "Viajes", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1655) },
                    { 35, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1656), "Teatro y Dramático", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1657) },
                    { 36, new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1657), "Lírico", new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1658) }
                });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1845), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1847), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1851), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1853), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1857), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1857) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 83, DateTimeKind.Utc).AddTicks(8446), new DateTime(2023, 9, 1, 15, 1, 24, 83, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(602), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(604), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(605), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(607), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(608), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(609), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(752), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(757), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(759), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 9, 1, 15, 1, 24, 84, DateTimeKind.Utc).AddTicks(763) });
        }
    }
}
