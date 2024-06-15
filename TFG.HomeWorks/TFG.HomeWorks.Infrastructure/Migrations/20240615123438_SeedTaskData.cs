using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TFG.HomeWorks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedTaskData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedBy", "AssignedTo", "CategoryId", "CreationDate", "DeadlineDate", "Description", "HouseId", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Ángel", "Usuario1", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9688), "Descripción de la Tarea 1", 1, "Tarea 1", "NEW" },
                    { 2, "Ángel", "Usuario2", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9700), "Descripción de la Tarea 2", 2, "Tarea 2", "NEW" },
                    { 3, "Ángel", "Usuario3", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9842), "Descripción de la Tarea 3", 3, "Tarea 3", "NEW" },
                    { 4, "Ángel", "Usuario4", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9848), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9850), "Descripción de la Tarea 4", 4, "Tarea 4", "NEW" },
                    { 5, "Ángel", "Usuario5", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9854), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9856), "Descripción de la Tarea 5", 5, "Tarea 5", "NEW" },
                    { 6, "Ángel", "Usuario6", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9866), "Descripción de la Tarea 6", 6, "Tarea 6", "NEW" },
                    { 7, "Ángel", "Usuario7", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9872), "Descripción de la Tarea 7", 7, "Tarea 7", "NEW" },
                    { 8, "Ángel", "Usuario8", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9878), "Descripción de la Tarea 8", 8, "Tarea 8", "NEW" },
                    { 9, "Ángel", "Usuario9", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9883), "Descripción de la Tarea 9", 9, "Tarea 9", "NEW" },
                    { 10, "Ángel", "Usuario10", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9892), "Descripción de la Tarea 10", 10, "Tarea 10", "NEW" },
                    { 11, "Ángel", "Usuario11", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9897), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9899), "Descripción de la Tarea 11", 11, "Tarea 11", "NEW" },
                    { 12, "Ángel", "Usuario12", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9905), "Descripción de la Tarea 12", 12, "Tarea 12", "NEW" },
                    { 13, "Ángel", "Usuario13", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9911), "Descripción de la Tarea 13", 13, "Tarea 13", "NEW" },
                    { 14, "Ángel", "Usuario14", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9917), "Descripción de la Tarea 14", 14, "Tarea 14", "NEW" },
                    { 15, "Ángel", "Usuario15", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9923), "Descripción de la Tarea 15", 15, "Tarea 15", "NEW" },
                    { 16, "Ángel", "Usuario16", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9929), "Descripción de la Tarea 16", 16, "Tarea 16", "NEW" },
                    { 17, "Ángel", "Usuario17", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9935), "Descripción de la Tarea 17", 17, "Tarea 17", "NEW" },
                    { 18, "Ángel", "Usuario18", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9942), "Descripción de la Tarea 18", 18, "Tarea 18", "NEW" },
                    { 19, "Ángel", "Usuario19", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9948), "Descripción de la Tarea 19", 19, "Tarea 19", "NEW" },
                    { 20, "Ángel", "Usuario20", 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9954), "Descripción de la Tarea 20", 20, "Tarea 20", "NEW" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
