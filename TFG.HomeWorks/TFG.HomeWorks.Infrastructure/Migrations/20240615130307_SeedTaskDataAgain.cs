using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFG.HomeWorks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedTaskDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 3, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 2, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 2, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 2, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2790), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 7, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 5, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "DeadlineDate" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 3, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2822), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 6, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 4, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 7, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2848), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "DeadlineDate" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 4, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 3, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2871), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 5, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 4, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "DeadlineDate" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 3, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 2, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 4, new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2919) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9848), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9854), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "DeadlineDate" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9897), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "DeadlineDate" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "DeadlineDate" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreationDate", "DeadlineDate" },
                values: new object[] { 1, new DateTime(2024, 6, 15, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 9, 13, 14, 34, 37, 661, DateTimeKind.Local).AddTicks(9954) });
        }
    }
}
