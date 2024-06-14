using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFG.HomeWorks.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAdminToHouseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAdmin",
                table: "Houses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Houses");
        }
    }
}
