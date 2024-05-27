using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFG.HomeWorks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameGenderPropertyUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Users",
                newName: "Gender");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "Genre");
        }
    }
}
