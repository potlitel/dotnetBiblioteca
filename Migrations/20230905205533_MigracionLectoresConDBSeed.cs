using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BootstrapDashboard.Migrations
{
    /// <inheritdoc />
    public partial class MigracionLectoresConDBSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lector",
                columns: table => new
                {
                    IdLector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime2", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lector", x => x.IdLector);
                });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 199, DateTimeKind.Utc).AddTicks(8932), new DateTime(2023, 9, 5, 20, 55, 33, 199, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3854), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3856), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3858), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3862), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3864), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3865), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3867), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3872), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3873), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3874), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3876), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3878), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3879), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3882), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3883), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3885), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3887), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3888), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3891), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3892), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3894), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3895), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3897), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3898), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3900), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.InsertData(
                table: "lector",
                columns: new[] { "IdLector", "Apellidos", "created_at", "Direccion", "Email", "Nombre", "Telefono", "updated_at" },
                values: new object[,]
                {
                    { 1, "Casanova Almanza", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2788), "Ourense, 25 43141 Vilallonga del Camp", "AnaiasCasanovaAlmanza@jourrapide.com", "Anaías", "783 962 738", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2791) },
                    { 2, "Castro Montoya", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2794), "Plaza Colón, 55 26100 Torrecilla en Cameros", "PericlesCastroMontoya@armyspy.com", "Pericles", "783 962 730", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2795) },
                    { 3, "Ontiveros Miranda", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2797), "Calvo Sotelo, 31 47230 Matapozuelos", "CarpoOntiverosMiranda@dayrep.com", "Carpo", "783 962 588", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2797) },
                    { 4, "Covarrubias Quiñones", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2800), "Cruce Casa de Postas, 3 18420 Lanjarón", "MonserratCovarrubiasQuinones@jourrapide.com", "Monserrat ", "734 910 062", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2800) },
                    { 5, "Gallardo Suárez", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2802), "Camiño Ancho, 43 37765 Monleón", "OmaroGallardoSuarez@dayrep.com", "Omaro", "748 412 755", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2803) },
                    { 6, "Olivares Escobar", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2806), "C/ Hijuela de Lojo, 30 20493 Berrobi", "SaulOlivaresEscobar@jourrapide.com", "Saúl", "662 479 434", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2807) },
                    { 7, "Barela Méndez", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2808), "Bouciña, 25 43780 Gandesa", "TuliaBarelaMendez@rhyta.com", "Tulia", "681 035 582", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2809) },
                    { 8, "Henríquez Pichardo", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2811), "C/ Domingo Beltrán, 54 02250 Abengibre", "NatividadHenriquezPichardo@teleworm.us", "Natividad", "664 470 154", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2811) },
                    { 9, "Alvarado González", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2813), "C/ Señores Curas, 11 12161 la Torre d'En Besora", "NaborAlvaradoGonzalez@dayrep.com", "Nabor", "633 722 764", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2814) },
                    { 10, "Solórzano Maya", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2815), "Rúa Olmos, 5 37330 Babilafuente", "EleodoroSolorzanoMaya@jourrapide.com", "Eleodoro", "627 022 447", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2816) },
                    { 11, "Toro Robles", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2817), "El Roqueo, 28 17230 Palamós", "YrkoToroRobles@dayrep.com", "Yrko", "775 984 852", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2818) },
                    { 12, "Corral Lara", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2820), "Padre Caro, 6 13760 Almuradiel", "EvelienCorralLara@armyspy.com", "Evelien", "616 556 997", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2821) },
                    { 13, "Ontiveros Vigil", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2823), "Escuadro, 57 46841 Castelló de Rugat", "FulgencioOntiverosVigil@teleworm.us", "Fulgencio", "669 306 461", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2823) },
                    { 14, "Espinosa Ledesma", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2826), "Paseo del Atlántico, 76 17500 Ripoll", "FerdinandEspinosaLedesma@teleworm.us", "Ferdinand", "651 089 265", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2827) },
                    { 15, "Barrientos Sedillo", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2829), "Atamaria, 39 36636 Ribadumia", "LupercoBarrientosSedillo@rhyta.com", "Luperco", "775 279 438", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2830) },
                    { 16, "Hernádez Villegas", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2834), "Constitución, 65 37111 Palacios del Arzobispo", "HeldaHernadezVillegas@rhyta.com", "Helda", "633 662 355", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2835) },
                    { 17, "Arreola Olivares", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2837), "C/ Los Herrán, 81 06810 Calamonte", "EliaArreolaOlivares@armyspy.com", "Elía", "612 597 999", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2838) },
                    { 18, "Vázquez Baca", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2840), "Cañadilla, 89 22300 Barbastro", "EneasVazquezBaca@dayrep.com", "Eneas", "759 793 434", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2841) },
                    { 19, "Rascón Angulo", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2843), "C/ Benito Guinea, 92 08330 Premià de Mar", "AbbiRasconAngulo@jourrapide.com", "Abbi", "674 325 474", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2844) },
                    { 20, "Rivas Espinosa", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2846), "Lamas Carbajal, 17 41566 Pedrera", "OrietaRivasEspinosa@jourrapide.com", "Orieta", "766 258 264", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2846) },
                    { 21, "Banda Alicea", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2849), "Camiño Real, 65 48480 Zaratamo", "MariselBandaAlicea@dayrep.com", "Marisel", "781 296 585", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2849) },
                    { 22, "Zamudio Adame", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2852), "Cruce Casa de Postas, 22 18430 Torvizcón", "PrudencianoZamudioAdame@dayrep.com", "Prudenciano", "722 720 072", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2853) },
                    { 23, "Vasquez Solano", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2855), "Atamaria, 2 36780 A Guarda", "AmalioVasquezSolano@dayrep.com", "Amalio", "722 801 512", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2855) },
                    { 24, "Valverde Elizondo", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2858), "Rúa de San Pedro, 79 37795 Berrocal de Salvatierra", "ZahirValverdeElizondo@armyspy.com", "Zahir", "606 229 390", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2858) },
                    { 25, "Saldana Pulido", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2860), "Carretera del Muelle, 67 12318 Portell de Morella", "LibertoSaldanaPulido@teleworm.us", "Liberto", "651 019 733", new DateTime(2023, 9, 5, 20, 55, 33, 207, DateTimeKind.Utc).AddTicks(2861) }
                });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4442), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4447), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4450), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4454), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4458), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4461), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4465), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4468), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4472), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4476), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "libros",
                keyColumn: "IdBook",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4479), new DateTime(2023, 9, 5, 20, 55, 33, 200, DateTimeKind.Utc).AddTicks(4480) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lector");

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

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1621), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1623), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1625), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1627), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1628), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1633), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1635), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1636), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1637), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1639), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1641), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1642), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1644), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1645), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1646), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1649), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1650), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1654), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1655), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1656), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "generos",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1657), new DateTime(2023, 9, 4, 1, 55, 32, 181, DateTimeKind.Utc).AddTicks(1658) });

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
    }
}
