using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TFG.HomeWorks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedHousesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isAdmin",
                table: "Houses",
                newName: "IsAdmin");

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "Description", "IsAdmin", "Name", "ProfileImage" },
                values: new object[,]
                {
                    { 100, "Dirección de mi casa 1", "Descripción de mi casa 1", false, "Mi Casa 1", "uploads/default.jpg" },
                    { 200, "Dirección de mi casa 2", "Descripción de mi casa 2", false, "Mi Casa 2", "uploads/default.jpg" },
                    { 300, "Dirección de mi casa 3", "Descripción de mi casa 3", false, "Mi Casa 3", "uploads/default.jpg" },
                    { 400, "Dirección de mi casa 4", "Descripción de mi casa 4", false, "Mi Casa 4", "uploads/default.jpg" },
                    { 500, "Dirección de mi casa 5", "Descripción de mi casa 5", false, "Mi Casa 5", "uploads/default.jpg" },
                    { 600, "Dirección de mi casa 6", "Descripción de mi casa 6", false, "Mi Casa 6", "uploads/default.jpg" },
                    { 700, "Dirección de mi casa 7", "Descripción de mi casa 7", false, "Mi Casa 7", "uploads/default.jpg" },
                    { 800, "Dirección de mi casa 8", "Descripción de mi casa 8", false, "Mi Casa 8", "uploads/default.jpg" },
                    { 900, "Dirección de mi casa 9", "Descripción de mi casa 9", false, "Mi Casa 9", "uploads/default.jpg" },
                    { 1000, "Dirección de mi casa 10", "Descripción de mi casa 10", false, "Mi Casa 10", "uploads/default.jpg" },
                    { 1100, "Dirección de mi casa 11", "Descripción de mi casa 11", false, "Mi Casa 11", "uploads/default.jpg" },
                    { 1200, "Dirección de mi casa 12", "Descripción de mi casa 12", false, "Mi Casa 12", "uploads/default.jpg" },
                    { 1300, "Dirección de mi casa 13", "Descripción de mi casa 13", false, "Mi Casa 13", "uploads/default.jpg" },
                    { 1400, "Dirección de mi casa 14", "Descripción de mi casa 14", false, "Mi Casa 14", "uploads/default.jpg" },
                    { 1500, "Dirección de mi casa 15", "Descripción de mi casa 15", false, "Mi Casa 15", "uploads/default.jpg" },
                    { 1600, "Dirección de mi casa 16", "Descripción de mi casa 16", false, "Mi Casa 16", "uploads/default.jpg" },
                    { 1700, "Dirección de mi casa 17", "Descripción de mi casa 17", false, "Mi Casa 17", "uploads/default.jpg" },
                    { 1800, "Dirección de mi casa 18", "Descripción de mi casa 18", false, "Mi Casa 18", "uploads/default.jpg" },
                    { 1900, "Dirección de mi casa 19", "Descripción de mi casa 19", false, "Mi Casa 19", "uploads/default.jpg" },
                    { 2000, "Dirección de mi casa 20", "Descripción de mi casa 20", false, "Mi Casa 20", "uploads/default.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Houses",
                newName: "isAdmin");
        }
    }
}
